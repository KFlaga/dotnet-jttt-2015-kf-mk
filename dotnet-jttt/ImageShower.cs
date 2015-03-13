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

        public void DoAction(string empty, object image)
        {
            // Tworzy nowe okienko z PictureBox'em w któym wyświetla się zadany obrazek
            Form picWindow = new Form();
            PictureBox picBox = new PictureBox();
            picWindow.Size = ((Image)image).Size;
            picBox.Size = ((Image)image).Size;
            picBox.Image = (Image)image;

            picWindow.Controls.Add(picBox);
            picWindow.Show();
        }
    }
}
