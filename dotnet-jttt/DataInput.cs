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
            tbx.Text = "";
            tbx.Location = new Point(50,45 + txbs.Count*40);

            Label lab = new Label();
            lab.Anchor = AnchorStyles.None;
            lab.AutoSize = true;
            lab.Name = "lab" + label;
            lab.Text = label;
            lab.Location = new Point(5, 45 + labels.Count * 40);

            this.Size = new Size(this.Size.Width, this.Size.Height + 30);
            this.Controls.Add(tbx);
            this.Controls.Add(lab);

            txbs.Add(tbx);
            labels.Add(lab);
        }

        public void RemoveLastRow()
        {
            this.Size = new Size(this.Size.Width, this.Size.Height - 30);
            this.Controls.Remove(txbs.Last());
            this.Controls.Remove(labels.Last());

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

        public bool CheckIfAllFieldsAreFilled()
        {
            if (txbs.Count == 0)
                return true;

            foreach (TextBox txb in txbs)
            {
                if (txb.Text == "")
                    return false;
            }

            return true;
        }
    }
}
