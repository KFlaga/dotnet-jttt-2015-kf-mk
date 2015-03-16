using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_jttt
{
    class ImageShower : IAction
    {

        public ImageShower() { }

        // Tworzy nowe okienko z PictureBox'em w któym wyświetla się zadany obrazek
        public void DoAction(string[] input, object img)
        {
            Image image = (Image)img;
            Form picWindow = new Form();
            PictureBox picBox = new PictureBox();
            picWindow.AutoSize = true;
            picWindow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            picBox.Size = image.Size;
            picBox.Image = image;

            picWindow.Controls.Add(picBox);
            picWindow.Show();
        }
    }
}
