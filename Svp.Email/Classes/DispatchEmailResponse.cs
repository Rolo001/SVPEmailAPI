namespace Svp.Email.Classes
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class DispatchEmailResponse
    {
        //Constructors

        public DispatchEmailResponse(DispatchEmailRequest request) : this(request, new string[] { }) 
        {
            Console.WriteLine("DispatchEmailResponse method (overload): DispatchEmailResponse ");
            //sendGrid application here
        }

        public DispatchEmailResponse(DispatchEmailRequest request, string[] errors)
        {
            Debug.Assert(request != null);
            Debug.Assert(errors != null);

            this.IsSuccess = errors.Length > 0;
            this.Request = request;
            this.Errors = errors;
        }

        //internal static object / Temporary return data, Add to extensions
        public static DispatchEmailResponse CreateFailed(DispatchEmailRequest request)
        {
            Console.WriteLine("Create Failed method: DispatchEmailResponse ");
            throw new NotImplementedException();
        }

        public static DispatchEmailResponse CreateFailed(DispatchEmailRequest request, string[] errors)
        {
            Console.WriteLine("Create Failed method (overload): DispatchEmailResponse ");
            throw new NotImplementedException();
        }

        public bool IsSuccess { get; private set; }
        public string[] Errors { get; private set; }
        public DispatchEmailRequest Request { get; private set; }
    }
} 