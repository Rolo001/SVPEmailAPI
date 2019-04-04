namespace Svp.Data.Interfaces
{
    using Svp.Data.Classes;
    using Svp.Data.Model;
    using System.Threading.Tasks;

    public interface IUserGateway
    {
        Task AddUser(User request);
        Task<string> GetUserDetail(int ID);
    }
}