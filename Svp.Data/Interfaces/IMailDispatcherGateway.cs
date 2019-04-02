using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Svp.Data.Interfaces
{
    public interface IMailDispatcherGateway
    {
        Task SendGridMail();
    }
}
