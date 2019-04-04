namespace Svp.Email.MailGun.Classes
{
    using System.Threading.Tasks;
    using Svp.Email.Classes;
    using Svp.Email.Interfaces;

    class MailGunEmailDispatcher : IEmailDispatcher
    {
        public Task<DispatchEmailResponse> Dispatch(DispatchEmailRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
