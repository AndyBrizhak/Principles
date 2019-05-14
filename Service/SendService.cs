using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class SendService
    {
        public int Date { get; set; }
        public void SendEmailDate(string Email, string Subject, string Text) { }
        public void SendFtpDate(string FtpAddres, string Port, Account User) { }

    }
}
