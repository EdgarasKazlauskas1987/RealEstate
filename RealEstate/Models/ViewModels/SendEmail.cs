using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstate.Models.ViewModels
{
    public class SendEmail
    {
        
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string Message { get; set; }
        public string ToEmail { get; set; }
       // public List<String> ToEmail { get; set; }
       // public bool isSelected { get; set; }
        //public bool ToEmail { get; set; }


    }
}