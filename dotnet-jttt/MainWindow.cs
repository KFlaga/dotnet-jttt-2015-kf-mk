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
        DataInputCreator diCreator;

        public MainWindow()
        {
            InitializeComponent();
            diCreator = new DataInputCreator();

            InitConditionsAndActions();

            this.combChooseAction.SelectedIndex = 0;
            this.combChooseCondition.SelectedIndex = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy nie ma pustych miejsc
            if (!diCondition.CheckIfAllFieldsAreFilled() || !diAction.CheckIfAllFieldsAreFilled())
            {
                MessageBox.Show("Należy wypełnić wszystkie pola");
                return;
            }

            // Pierw sprawdzenie warunku
            conditions[curCond].CheckCondition(diCondition.GetTextInput()[1], diCondition.GetTextInput()[0]);
            object res = conditions[curCond].GetResult();

            if (res == null)
            {
                MessageBox.Show("Warunek nie spelniony\n");
                return;
            }

            actions[curAction].DoAction(diAction.GetTextInput()[0], res);
        }

        private void combChooseCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            curCond = combChooseCondition.SelectedIndex;
            mainLayout.Controls.Remove(diCondition);
            diCondition = diCreator.GetConditionInput(curCond);
            mainLayout.Controls.Add(diCondition, 1, 2);
        }

        private void combChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            curAction = combChooseAction.SelectedIndex;
            mainLayout.Controls.Remove(diAction);
            diAction = diCreator.GetActionInput(curAction);
            mainLayout.Controls.Add(diAction, 1, 5);
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
