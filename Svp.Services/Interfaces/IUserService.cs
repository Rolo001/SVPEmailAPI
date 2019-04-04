using Svp.Services.Models;
using System.Threading.Tasks;

namespace Svp.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUserAsync(int ID);
        Task AddUserAsync(SignupRequest request);
    }
}