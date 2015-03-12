using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_jttt
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txbURL.Text == "" || txbKey.Text == "" || txbMail.Text == "")
            {
                MessageBox.Show("Należy podać wartości we wszystkich lukach\n");
                return;
            }
            // Pobieranie obrazka
            ImgDownloader downloader = new ImgDownloader(txbURL.Text);
            Image img = downloader.DownloadIfKeyIsInTitle(txbKey.Text);

            if (img == null)
            {
                MessageBox.Show("Nie znalazlo obrazka\n");
                return;
            }
            picbTest.Image = img; // dziala
            img.Save("d:\\obrazek.jpg"); 

            EMailer mailer = new EMailer();
            mailer.SendMail(txbMail.Text, img);
        }
    }
}
