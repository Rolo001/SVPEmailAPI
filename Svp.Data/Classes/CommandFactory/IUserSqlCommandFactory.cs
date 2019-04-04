namespace Svp.Data.Classes.CommandFactory
{
    using Svp.Data.Model;
    using System.Data.SqlClient;

    public interface IUserSqlCommandFactory
    {
        SqlCommand RetrieveUserSqlCommand(int ID);
        SqlCommand AddUserSqlCommand(User user);
    }
}