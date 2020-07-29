using System.Linq;
using Learning.Repository;

namespace Learning.Business
{
    public interface IClassManager
    {
        ClassModel[] Classes { get; }
        ClassModel Class(int classId);
    }

    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }

        public ClassModel(int id, string name, string description, decimal price)
        {
            ClassId = id;
            ClassName = name;
            ClassDescription = description;
            ClassPrice = price;
        }
    }

    public class ClassManager : IClassManager
    {
        private readonly IClassRepository classRepository;

        public ClassManager(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public ClassModel[] Classes
        {
            get
            {
                return classRepository.Class
                                         .Select(t => new ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                                         .ToArray();
            }
        }

        //public ClassModel[] Classess => throw new System.NotImplementedException();

        public ClassModel Class(int classId)
        {
            var classModel = classRepository.Classes(classId);
            return new ClassModel(classModel.ClassId, classModel.ClassName, classModel.ClassDescription, classModel.ClassPrice);
        }
    }
}