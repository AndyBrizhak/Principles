﻿using System;
using System.Collections.Generic;

namespace Service
{
   public class Service1
   {
       public string Data { get; set; }
       public string LoadFromFile(string Path) => string.Empty;
       public string LoadFromUrl(string Url) => string.Empty;
       public void   SendEmailData(string Email, string Subject, string Text) { }
       public void SendFtpData(string FtpAddres, string Port, Account User) { }
       public void SaveXmlData(List<string> DataList) { }
       public void SaveJsonData(List<string> DataList) { }
   }

}
