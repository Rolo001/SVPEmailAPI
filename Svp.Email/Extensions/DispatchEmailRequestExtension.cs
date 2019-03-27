namespace Svp.Email.Extensions
{
    using System;

    //If  we could place this with the existing Extension with the same name
    public static class DispatchEmailRequestExtension
    {
        public static bool IsValid()
        {
            throw new NotImplementedException();
            //why not use data anotations
            //specification pattern
            //return false; //temporary return data
        }

        public static string[] GetErrors()
        {
            //get error messages from validations?
            //error template
            Console.WriteLine("get error method: DispatchEmailRequest");
            return new string[] { "error", "GetError method" };
        }
    }
}
