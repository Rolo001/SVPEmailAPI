using System.Data.SqlClient;

namespace Svp.Data.Classes.CommandFactory
{
    public interface IUserSqlCommandFactory
    {
        SqlCommand RetrieveUserSqlCommand(int ID);
    }
}