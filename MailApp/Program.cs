using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using SmtpClient = System.Net.Mail.SmtpClient;
using System.Text;
using System.Net;

namespace MailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string message = "All the Best";
                MailMessage msg = new MailMessage("golu21397@outlook.com", "prince@yopmail.com");
                msg.Sender = new MailAddress("golu21397@outlook.com", "Prince Mishra");
                msg.From = msg.Sender;
                msg.IsBodyHtml = true;
                msg.Body = message;
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.office365.com",
                    Port = 25, // You can use Port 25 if 587 is blocked (mine is!)
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                };
                client.Credentials = new System.Net.NetworkCredential("golu21397@outlook.com", "Vishal21397@");
                client.Send(msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    }






//// 

this is adding for the testing purpose commented lines need to remove after that

