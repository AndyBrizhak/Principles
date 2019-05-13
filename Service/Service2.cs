using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Service2
    {
        public string Data { get; set; }
        public string LoadFromFile(string Path) => string.Empty;
        public string LoadFromUrl(string Url) => string.Empty;
        public void SendEmailData(string Email, string Subject, string Text) { }
        public void SendFtpData(string FtpAddres, string Port, Account User) { }
        public void SaveXmlData(List<string> DataList) { }
        public void SaveJsonData(List<string> DataList) { }
    }
}
