using System.Threading.Tasks;

namespace Svp.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUserAsync(int ID);
    }
}