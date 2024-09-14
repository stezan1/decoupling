using DataAccessLayer;

namespace FactoryRepository
{
    public static class FactoryRepo
    {
        public static IRepository Create(int i)
        {
            if (i == 0)
            {
                return new SqlServer();
            }
            else if (i == 1)
            {
                return new Oracle();
            }
            else
            {
                return new Mysql();
            }
            return null;
        }
    }
}
