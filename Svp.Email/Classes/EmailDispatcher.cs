namespace Svp.Email.Classes
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Svp.Email.Classes.Exceptions;
    using Svp.Email.Interfaces;

    public class EmailDispatcher 
    {
        private readonly IEmailDispatcher _dispatcher;

        public EmailDispatcher()
        {
        }

        public EmailDispatcher(IEmailDispatcher dispatcher)
        {
            Debug.Assert(dispatcher != null, "The dispatcher should not be null, check configuration or DI.");
            Console.WriteLine("EmailDispatcher constructor initialization");
            this._dispatcher = dispatcher;
        }

        public async Task<DispatchEmailResponse> Dispatch(DispatchEmailRequest request)
        {
            var result = DispatchEmailResponse.CreateFailed(request); //Overload CreateFailed 
            try
            {
                if (!request.IsValid())
                {
                    result = DispatchEmailResponse.CreateFailed(request, request.GetErrors());
                }
                else
                {
                    result = await this._dispatcher.Dispatch(request);
                }
            }
            catch (Exception e)
            {
                throw new EmailDispatcherException(e);
            }
            return result;
        }
    }
}
