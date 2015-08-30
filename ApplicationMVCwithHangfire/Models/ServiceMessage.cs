using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationMVCwithHangfire.Models
{
    public class ServiceMessage
    {
        public static string Messages()
        {
            string message = "This message is automatic with hangfire background job!";
            return message;
        }
    }
}