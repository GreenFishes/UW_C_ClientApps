

using Learning.ProductDatabase;

namespace Learning.Repository
{
    public class DatabaseAccessor
    {
        private static readonly ClassDbEntities entities;

        static DatabaseAccessor()
        {
            entities = new ClassDbEntities();
            entities.Database.Connection.Open();
        }

        public static ClassDbEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}