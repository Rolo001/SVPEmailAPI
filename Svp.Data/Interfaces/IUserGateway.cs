namespace Svp.Data.Interfaces
{
    using Svp.Data.Classes;
    using System.Threading.Tasks;

    public interface IUserGateway
    {
        Task Save(SaveUserRequest request);
        Task<string> GetUserDetail(int ID);
    }
}