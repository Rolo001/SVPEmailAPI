namespace Svp.Email
{
    using System;
    using Svp.Email.Classes;
    using Svp.Email.Interfaces;

    class Program
    {
        //private readonly IEmailDispatcher dispatch;

        //public Program(IEmailDispatcher dispatch)
        //{
        //    this.dispatch = dispatch;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmailDispatcher dispatcher = new EmailDispatcher();
            
            Console.ReadKey();
        }
    }
}
