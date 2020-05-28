using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Blowout_Kraupp_Tyler.Controllers
{
    public class ContactController : Controller
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "helikrauppter@gmail.com"; //Sender Email Address  
        static string password = "TacoBoi12"; //Sender Password   

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Message = "Please call Support at ";
            ViewBag.Number = "801 - 555 - 1212.";
            ViewBag.End = " Thank you!";

            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Message = "Thank you " + name + "! We will send an email to you at " + email;

            SendEmail(name, email);

            return View("Index");
        }


        public static void SendEmail(string name, string emailToAddress)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = "Hi " + name;
                mail.Body = "This is a test email, and you are my new best friend " + emailToAddress;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}