using System.Threading.Tasks;

namespace Svp.Services.Interfaces
{
    public interface ISendGridService
    {
        Task<string> SendMail();
    }
}