using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_jttt
{
    public partial class DataInput : UserControl
    {
        List<TextBox> txbs;
        List<Label> labels;

        public DataInput()
        {
            InitializeComponent();
            txbs = new List<TextBox>();
            labels = new List<Label>();
        }

        public void SetTitle(string[] lines)
        {
            txbTitle.Lines = lines;
        }

        public void AddTextInput(string label)
        {
            TextBox tbx = new TextBox();
            tbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            tbx.Name = "txb" + label;
            tbx.Size = new Size(340, 20);
            tbx.Text = "Wpisz tu cos";

            Label lab = new Label();
            lab.Anchor = AnchorStyles.None;
            lab.AutoSize = true;
            lab.Name = "lab" + label;
            lab.Text = label;

            this.Size = new Size(this.Size.Width, this.Size.Height + 30);
            mainLayout.Size = new Size(mainLayout.Size.Width, mainLayout.Size.Height + 30);
            mainLayout.RowCount = mainLayout.RowCount + 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            mainLayout.Controls.Add(lab, 0, mainLayout.RowCount - 1);
            mainLayout.Controls.Add(tbx, 0, mainLayout.RowCount - 1);

            txbs.Add(tbx);
            labels.Add(lab);
        }

        public void RemoveLastRow()
        {
            this.Size = new Size(this.Size.Width, this.Size.Height - 30);
            mainLayout.Size = new Size(mainLayout.Size.Width, mainLayout.Size.Height - 30);
            mainLayout.Controls.Remove(txbs.Last());
            mainLayout.Controls.Remove(labels.Last());
            mainLayout.RowCount = mainLayout.RowCount - 1;

            txbs.RemoveAt(txbs.Count - 1);
            labels.RemoveAt(labels.Count - 1);
        }

        public string[] GetTextInput()
        {
            string[] input = new string[txbs.Count];
            for (int i = 0; i < txbs.Count; i++)
            {
                input[i] = txbs[i].Text;
            }
            return input;
        }
    }
}
