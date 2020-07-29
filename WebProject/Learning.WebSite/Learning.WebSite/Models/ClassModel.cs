namespace Learning.WebSite.Models
{
    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }


        public string ClassDescription{ get; set; }
        public decimal ClassPrice { get; set; }




        public ClassModel(int id, string name, string description, decimal price)
        {
            ClassId = id;
            ClassName = name;

            ClassDescription = description;
            ClassPrice = price;

        }
    }
}