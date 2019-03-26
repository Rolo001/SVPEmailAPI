namespace Svp.Email.Interfaces
{
    using System.Threading.Tasks;
    using Svp.Email.Classes;
    public interface IEmailDispatcher
    {
        Task<DispatchEmailResponse> Dispatch(DispatchEmailRequest request);
    }
}
