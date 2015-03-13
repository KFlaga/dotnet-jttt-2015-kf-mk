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
        List<IConditionWithResult> conditions;
        List<IAction> actions;
        int curCond;
        int curAction;

        public MainWindow()
        {
            InitializeComponent();

            this.combChooseAction.SelectedIndex = 0;
            this.combChooseCondition.SelectedIndex = 0;

            InitConditionsAndActions();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txbURL.Text == "" || txbKey.Text == "" || txbMail.Text == "")
            {
                MessageBox.Show("Należy podać wartości we wszystkich lukach\n");
                return;
            }

            // Pierw sprawdzenie warunku
            conditions[curCond].CheckCondition(txbKey.Text, txbURL.Text);
            object res = conditions[curCond].GetResult();

            if (res == null)
            {
                MessageBox.Show("Warunek nie spelniony\n");
                return;
            }

            actions[curAction].DoAction(txbMail.Text, res);
        }

        private void combChooseCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            curCond = combChooseCondition.SelectedIndex;
        }

        private void combChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            curAction = combChooseAction.SelectedIndex;
        }

        private void InitConditionsAndActions()
        {
            conditions = new List<IConditionWithResult>();
            actions = new List<IAction>();

            conditions.Add(new DownloadImageIfTitleContainsKey());

            actions.Add(new EMailer());
            actions.Add(new ImageShower());
        }
    }
}
