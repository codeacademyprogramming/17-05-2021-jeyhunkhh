using System.Data.SqlClient;

namespace _160720.Infrastructure
{
    abstract public class BaseService
    {
        protected SqlConnection _connection;

        public BaseService()
        {
            _connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=School;Trusted_Connection=True;");
        }
    }
}
