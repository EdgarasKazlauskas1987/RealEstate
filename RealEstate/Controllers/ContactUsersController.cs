using RealEstate.Models;
using RealEstate.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class ContactUsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ContactUsers
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult SendEmails()
        {
            var listOfImages = db.Users;
            List<String> usersEmails = new List<String>();

            foreach (var item in listOfImages)
            {
                usersEmails.Add(item.Email);  
            }
            //ViewBag.UsersEmails = usersEmails;
           ViewBag.UsersEmails = new SelectList(usersEmails);
            
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendEmails(SendEmail viewModel)
        {
            
            InquiryFormModel model= new InquiryFormModel();
            model.FromName = viewModel.FromName;
            model.FromEmail = viewModel.FromEmail;
            model.Message = viewModel.Message;
            
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(viewModel.ToEmail));
                //message.To.Add(new MailAddress("edgarasvilija@gmail.com"));// replace with valid value 
                message.From = new MailAddress("sender@outlook.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "kaunasrealestate@gmail.com",  // replace with valid value
                        Password = "kazlaskazlas"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }


        /*
                [HttpPost]
                public ActionResult Index(List<String> emails)
                {
                    return View();
                } */
    }
}