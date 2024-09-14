namespace DataAccessLayer
{
    public interface IRepository
    {
        void Save();
    }
    public class SqlServer : IRepository
    {
        public void Save()
        {
            Console.WriteLine("Saved to SQL Server.");
        }
    }
    public class Mysql : IRepository
    {
        public void Save()
        {
            Console.WriteLine("Saved to MySQL.");
        }
    }
    public class Oracle : IRepository
    {
        public void Save()
        {
            Console.WriteLine("Saved to Oracle.");
        }
    }
}
