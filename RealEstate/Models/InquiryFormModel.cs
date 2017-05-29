using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    public class InquiryFormModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.SharedTexts.SharedTexts), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "YourName", ResourceType = typeof(Resources.ContactsTexts.ContactsTexts))]
        public string FromName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedTexts.SharedTexts), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "YourEmail", ResourceType = typeof(Resources.ContactsTexts.ContactsTexts))]
        public string FromEmail { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedTexts.SharedTexts), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Message", ResourceType = typeof(Resources.ContactsTexts.ContactsTexts))]
        public string Message { get; set; }
    }
}

