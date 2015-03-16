using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dotnet_jttt
{
    class EMailer : IAction
    {
        string adress;
        Image img;

        public EMailer()
        {

        }

        public void DoAction(string[] input, object image) // Nie chce wysylac
        {
            adress = input[0];
            img = (Image)image;

            MemoryStream imgStream = new MemoryStream();
            img.Save(imgStream, img.RawFormat);

            MailMessage msg = new System.Net.Mail.MailMessage("emailertestspam@gmail.com", "emailertestspam@gmail.com", "test", "test emailera");
            Attachment att = new Attachment(imgStream, "obrazek");
            msg.Attachments.Add(att);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 465); // server googla i port
            client.Credentials = new NetworkCredential("emailertestspam@gmail.com", "dotnetpass");
            client.EnableSsl = true;
            client.SendCompleted += client_SendCompleted;
            string token = "test";
            client.SendAsync(msg, token);

        }

        void client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                MessageBox.Show(token + ": Send canceled.");
            }
            if (e.Error != null)
            {
                MessageBox.Show(token + ": " + e.Error.ToString());
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }
    }
}