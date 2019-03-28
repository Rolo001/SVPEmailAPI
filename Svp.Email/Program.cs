namespace Svp.Email
{
    using System;
    using Svp.Email.Classes;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EmailDispatcher dispatcher = new EmailDispatcher(null);
            
            Console.ReadKey();
        }
    }
}
