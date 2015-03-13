namespace dotnet_jttt
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.combChooseCondition = new System.Windows.Forms.ComboBox();
            this.labChooseCondition = new System.Windows.Forms.Label();
            this.labJesli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labChooseAction = new System.Windows.Forms.Label();
            this.combChooseAction = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.diCondition = new dotnet_jttt.DataInput();
            this.diAction = new dotnet_jttt.DataInput();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.AutoSize = true;
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.labChooseCondition, 1, 0);
            this.mainLayout.Controls.Add(this.labJesli, 0, 0);
            this.mainLayout.Controls.Add(this.label4, 0, 3);
            this.mainLayout.Controls.Add(this.labChooseAction, 1, 3);
            this.mainLayout.Controls.Add(this.combChooseCondition, 1, 1);
            this.mainLayout.Controls.Add(this.combChooseAction, 1, 4);
            this.mainLayout.Controls.Add(this.btnAccept, 1, 6);
            this.mainLayout.Controls.Add(this.diCondition, 1, 2);
            this.mainLayout.Controls.Add(this.diAction, 1, 5);
            this.mainLayout.Location = new System.Drawing.Point(57, 12);
            this.mainLayout.MinimumSize = new System.Drawing.Size(500, 405);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 7;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayout.Size = new System.Drawing.Size(530, 405);
            this.mainLayout.TabIndex = 13;
            // 
            // combChooseCondition
            // 
            this.combChooseCondition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combChooseCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseCondition.FormattingEnabled = true;
            this.combChooseCondition.Items.AddRange(new object[] {
            "Opis obrazka na stronie zawiera klucz"});
            this.combChooseCondition.Location = new System.Drawing.Point(108, 34);
            this.combChooseCondition.Name = "combChooseCondition";
            this.combChooseCondition.Size = new System.Drawing.Size(391, 21);
            this.combChooseCondition.TabIndex = 0;
            this.combChooseCondition.SelectedIndexChanged += new System.EventHandler(this.combChooseCondition_SelectedIndexChanged);
            // 
            // labChooseCondition
            // 
            this.labChooseCondition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labChooseCondition.AutoSize = true;
            this.labChooseCondition.Location = new System.Drawing.Point(259, 7);
            this.labChooseCondition.Name = "labChooseCondition";
            this.labChooseCondition.Size = new System.Drawing.Size(92, 13);
            this.labChooseCondition.TabIndex = 3;
            this.labChooseCondition.Text = "Wybierz warunek:";
            // 
            // labJesli
            // 
            this.labJesli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labJesli.AutoSize = true;
            this.labJesli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labJesli.Location = new System.Drawing.Point(9, 18);
            this.labJesli.Name = "labJesli";
            this.mainLayout.SetRowSpan(this.labJesli, 2);
            this.labJesli.Size = new System.Drawing.Size(81, 24);
            this.labJesli.TabIndex = 4;
            this.labJesli.Text = "Jesli to:";
            this.labJesli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.mainLayout.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "To to:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labChooseAction
            // 
            this.labChooseAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labChooseAction.AutoSize = true;
            this.labChooseAction.Location = new System.Drawing.Point(279, 178);
            this.labChooseAction.Name = "labChooseAction";
            this.labChooseAction.Size = new System.Drawing.Size(35, 13);
            this.labChooseAction.TabIndex = 6;
            this.labChooseAction.Text = "Wybierz akcję:";
            // 
            // combChooseAction
            // 
            this.combChooseAction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combChooseAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseAction.FormattingEnabled = true;
            this.combChooseAction.Items.AddRange(new object[] {
            "Wyślij obrazek na email",
            "Pokaz obrazek na ekranie"});
            this.combChooseAction.Location = new System.Drawing.Point(108, 204);
            this.combChooseAction.Name = "combChooseAction";
            this.combChooseAction.Size = new System.Drawing.Size(391, 21);
            this.combChooseAction.TabIndex = 7;
            this.combChooseAction.SelectedIndexChanged += new System.EventHandler(this.combChooseAction_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.Location = new System.Drawing.Point(240, 360);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 33);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Start";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // diCondition
            // 
            this.diCondition.BackColor = System.Drawing.SystemColors.Info;
            this.diCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diCondition.Location = new System.Drawing.Point(100, 60);
            this.diCondition.Margin = new System.Windows.Forms.Padding(0);
            this.diCondition.Name = "diCondition";
            this.diCondition.Size = new System.Drawing.Size(410, 45);
            this.diCondition.TabIndex = 9;
            // 
            // diAction
            // 
            this.diAction.BackColor = System.Drawing.SystemColors.Info;
            this.diAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diAction.Location = new System.Drawing.Point(100, 230);
            this.diAction.Margin = new System.Windows.Forms.Padding(0);
            this.diAction.Name = "diAction";
            this.diAction.Size = new System.Drawing.Size(410, 45);
            this.diAction.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainWindow";
            this.Text = "JTTT";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label labChooseCondition;
        private System.Windows.Forms.Label labJesli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labChooseAction;
        private System.Windows.Forms.ComboBox combChooseCondition;
        private System.Windows.Forms.ComboBox combChooseAction;
        private System.Windows.Forms.Button btnAccept;
        private DataInput diCondition;
        private DataInput diAction;
    }
}

