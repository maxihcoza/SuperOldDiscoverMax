using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using DiscoverMax.Models;

namespace DiscoverMax.Controllers
{
    public class aboutController : Controller
    {
        public ActionResult home()
        {
            return View();
        }
        public ActionResult personal()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult contact(Contact c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    MailAddress from = new MailAddress("users@discovermax.co.za");
                    StringBuilder sb = new StringBuilder();

                    msg.To.Add("talk@discovermax.co.za");
                    msg.Subject = "Message from Website";
                    msg.IsBodyHtml = false;

                    sb.Append("Name: " + c.Name);
                    sb.Append(Environment.NewLine);
                    sb.Append("E-mail: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Contact Number: " + c.Number);
                    sb.Append(Environment.NewLine);
                    sb.Append("Message: " + c.Message);

                    msg.Body = sb.ToString();

                    SmtpClient smtp = new SmtpClient();
                    smtp.Send(msg);

                    msg.Dispose();

                    return View("messagesent");
                }
                catch (Exception)
                {
                    return View("messagenotsent");
                }
            }
            return View();
        }
        public ActionResult education()
        {
            return View();
        }
        public ActionResult projects()
        {
            return View();
        }
        public ActionResult webservices()
        {
            return View();
        }
        public ActionResult extrainfoaboutmywebservices()
        {
            return View();
        }
        public ActionResult whatcreatingawebsiteinvolves()
        {
            return View();
        }
        public ActionResult curriculumvitae()
        {
            return View();
        }
        public ActionResult websitecredits()
        {
            return View();
        }
        public ActionResult contactform(Contact c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    MailAddress from = new MailAddress("users@discovermax.co.za");
                    StringBuilder sb = new StringBuilder();

                    msg.To.Add("talk@discovermax.co.za");
                    msg.Subject = "Message from Website";
                    msg.IsBodyHtml = false;

                    sb.Append("Name: " + c.Name);
                    sb.Append(Environment.NewLine);
                    sb.Append("E-mail: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Contact Number: " + c.Number);
                    sb.Append(Environment.NewLine);
                    sb.Append("Message: " + c.Message);

                    msg.Body = sb.ToString();

                    SmtpClient smtp = new SmtpClient();
                    smtp.Send(msg);

                    msg.Dispose();

                    return View("messagesent");
                }
                catch (Exception)
                {
                    return View("messagenotsent");
                }
            }
            return PartialView("contactform",c);
        }
    }
}