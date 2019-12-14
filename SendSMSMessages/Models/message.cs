using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendSMSMessages.ViewModels
{
    public class Message
    {
        public string To { get; set; }
        public string ContentMsg { get; set; }
    }
}