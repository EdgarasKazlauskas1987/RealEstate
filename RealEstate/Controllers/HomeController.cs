using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private Random randomGenerator = new Random();

        //GET: Home page
        public ActionResult Index()
        {
            IEnumerable<Project> demo = db.Projects;
            List<Project> allProjects = new List<Project>();
            allProjects = demo.ToList();
            List<Project> fourProjects = new List<Project>();
            

            for(int i = 0; i<4; i++)
            {
                var randomNumber = randomGenerator.Next(allProjects.Count());
                fourProjects.Add(allProjects.ElementAt(randomNumber));
                allProjects.Remove(allProjects.ElementAt(randomNumber));
            }

            var listOfImages = db.Images;

            ViewBag.ImagesList = listOfImages;
            ViewBag.FourRandomProjects = fourProjects;

            return View();
        } 
       
        //GET: Contacts view
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //GET: Inquiry form
        public ActionResult InquiryForm()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //POST: User sends Inquiry form to company
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> InquiryForm(InquiryFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("edgarasvilija@gmail.com"));  // replace with valid value 
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

        //GET: Message sent confirmation view
        public ActionResult Sent()
        {
            return View();
        }
    }
}