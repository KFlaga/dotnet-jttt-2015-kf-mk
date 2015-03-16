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

        public void DoAction(string[] input, object image)
        {
            adress = input[0];
            img = (Image)image;

            MailMessage msg = new System.Net.Mail.MailMessage("emailertestspam@gmail.com", adress, "test", "test emailera");
            img.Save("obrazek.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Attachment att = new Attachment("obrazek.jpg");
            msg.Attachments.Add(att);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // server googla i port
            client.Credentials = new NetworkCredential("emailertestspam@gmail.com", "dotnetpass");
            client.EnableSsl = true;
            client.Send(msg);
            Logger.Instance.AddLog("Próba wysłania wiadomości");
        }

        void client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                Logger.Instance.AddLog("Wysłanie wiadomości powiodło się");
                MessageBox.Show("Message sent.");
                return;
            }
            Logger.Instance.AddLog("Wysłanie wiadomości nie powiodło się");
        }
    }
}