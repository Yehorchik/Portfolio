using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using System.Net;

namespace Portfolio.Controllers
{
    public class PortfolioController: Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("sendMail")]
        public IActionResult Send(Mail mail ,EventArgs e)
        {

            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("egorchikmelnyk@gmail.com");
            message.From = new MailAddress($"{mail.Name}@gmail.com", mail.Email, System.Text.Encoding.UTF8);
            message.Subject = $"Job From {mail.Name}";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = mail.Message;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.High;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("egorchikmelnyk@gmail.com", "64319abcd");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(message);
            return Redirect("/");
        }
    }
}