using System.Linq;

namespace Learning.Repository
{
    public interface IClassRepository
    {
        ClassModel[] Class { get; }
        ClassModel Classes(int classId);
    }

    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public string ClassDescription { get; set; }
        public decimal ClassPrice{ get; set; }

    }

    public class ClassRepository : IClassRepository
    {
        public ClassModel[] Classes
        {
            get
            {
                return DatabaseAccessor.Instance.Classes
                                               .Select(t => new ClassModel { ClassId = t.ClassId, ClassName = t.ClassName, ClassDescription = t.ClassDescription, ClassPrice = t.ClassPrice })
                                               .ToArray();
            }
        }

        public ClassModel[] Class => throw new System.NotImplementedException();

        public ClassModel Category(int classId)
        {
            var category = DatabaseAccessor.Instance.Classes
                                                   .Where(t => t.ClassId == classId)
                                                   .Select(t => new ClassModel { ClassId = t.ClassId, ClassName = t.ClassName, ClassDescription = t.ClassDescription, ClassPrice = t.ClassPrice })
                                                   .First();
            return category;
        }

        ClassModel IClassRepository.Classes(int classId)
        {
            throw new System.NotImplementedException();
        }
    }
}