using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medcs.Common.Medcs.Common.Utils.Helpers
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
