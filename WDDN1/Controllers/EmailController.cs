using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace WDDN1.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(string recieverEmail, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("demopractice2010@gmail.com", "Message from Admin");
                    var re = new MailAddress(recieverEmail, "Reciever");

                    var password = "demo123@*";
                    var sub = subject;
                    var body = message;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };

                    using (var m = new MailMessage(senderEmail, re)
                    {
                        Subject = subject,
                        Body = body
                    }
                    )
                    {
                        smtp.Send(m);
                    }
                }
            }

            catch (Exception e)
            {
                ViewBag.Error = "There is a problem in sending email " + e;
            }
            return View();
        }
    }
}