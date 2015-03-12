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
            this.btnAccept = new System.Windows.Forms.Button();
            this.picbTest = new System.Windows.Forms.PictureBox();
            this.labJesli = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labToTo = new System.Windows.Forms.Label();
            this.labChooseAction = new System.Windows.Forms.Label();
            this.labChooseCondition = new System.Windows.Forms.Label();
            this.combChooseAction = new System.Windows.Forms.ComboBox();
            this.labKey = new System.Windows.Forms.Label();
            this.labURL = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.layCondition = new System.Windows.Forms.TableLayoutPanel();
            this.combChooseCondition = new System.Windows.Forms.ComboBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.labMail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbTest)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.layCondition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.SetColumnSpan(this.btnAccept, 6);
            this.btnAccept.Location = new System.Drawing.Point(164, 336);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(164, 34);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Start";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // picbTest
            // 
            this.picbTest.Location = new System.Drawing.Point(555, 28);
            this.picbTest.Name = "picbTest";
            this.picbTest.Size = new System.Drawing.Size(87, 79);
            this.picbTest.TabIndex = 7;
            this.picbTest.TabStop = false;
            // 
            // labJesli
            // 
            this.labJesli.AutoSize = true;
            this.labJesli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labJesli.Location = new System.Drawing.Point(3, 13);
            this.labJesli.Name = "labJesli";
            this.labJesli.Size = new System.Drawing.Size(81, 24);
            this.labJesli.TabIndex = 11;
            this.labJesli.Text = "Jeśli to:";
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 7;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.Controls.Add(this.tableLayoutPanel1, 1, 6);
            this.mainLayout.Controls.Add(this.combChooseCondition, 1, 1);
            this.mainLayout.Controls.Add(this.layCondition, 1, 2);
            this.mainLayout.Controls.Add(this.labJesli, 0, 1);
            this.mainLayout.Controls.Add(this.combChooseAction, 1, 5);
            this.mainLayout.Controls.Add(this.labToTo, 0, 5);
            this.mainLayout.Controls.Add(this.labChooseCondition, 1, 0);
            this.mainLayout.Controls.Add(this.labChooseAction, 1, 4);
            this.mainLayout.Controls.Add(this.btnAccept, 0, 7);
            this.mainLayout.Location = new System.Drawing.Point(12, 12);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 8;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.Size = new System.Drawing.Size(516, 405);
            this.mainLayout.TabIndex = 13;
            // 
            // labToTo
            // 
            this.labToTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labToTo.AutoSize = true;
            this.labToTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labToTo.Location = new System.Drawing.Point(11, 195);
            this.labToTo.Name = "labToTo";
            this.labToTo.Size = new System.Drawing.Size(64, 24);
            this.labToTo.TabIndex = 15;
            this.labToTo.Text = "To to:";
            // 
            // labChooseAction
            // 
            this.labChooseAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labChooseAction.AutoSize = true;
            this.mainLayout.SetColumnSpan(this.labChooseAction, 4);
            this.labChooseAction.Location = new System.Drawing.Point(251, 181);
            this.labChooseAction.Name = "labChooseAction";
            this.labChooseAction.Size = new System.Drawing.Size(77, 13);
            this.labChooseAction.TabIndex = 16;
            this.labChooseAction.Text = "Wybierz akcję:";
            // 
            // labChooseCondition
            // 
            this.labChooseCondition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labChooseCondition.AutoSize = true;
            this.mainLayout.SetColumnSpan(this.labChooseCondition, 4);
            this.labChooseCondition.Location = new System.Drawing.Point(244, 0);
            this.labChooseCondition.Name = "labChooseCondition";
            this.labChooseCondition.Size = new System.Drawing.Size(92, 13);
            this.labChooseCondition.TabIndex = 12;
            this.labChooseCondition.Text = "Wybierz warunek:";
            this.labChooseCondition.Click += new System.EventHandler(this.labChooseCondition_Click);
            // 
            // combChooseAction
            // 
            this.combChooseAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.SetColumnSpan(this.combChooseAction, 4);
            this.combChooseAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseAction.FormattingEnabled = true;
            this.combChooseAction.Location = new System.Drawing.Point(127, 197);
            this.combChooseAction.Name = "combChooseAction";
            this.combChooseAction.Size = new System.Drawing.Size(325, 21);
            this.combChooseAction.TabIndex = 10;
            // 
            // labKey
            // 
            this.labKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labKey.AutoSize = true;
            this.labKey.Location = new System.Drawing.Point(8, 86);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(36, 13);
            this.labKey.TabIndex = 5;
            this.labKey.Text = "Klucz:";
            // 
            // labURL
            // 
            this.labURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labURL.AutoSize = true;
            this.labURL.Location = new System.Drawing.Point(10, 55);
            this.labURL.Name = "labURL";
            this.labURL.Size = new System.Drawing.Size(32, 13);
            this.labURL.TabIndex = 4;
            this.labURL.Text = "URL:";
            this.labURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbURL
            // 
            this.txbURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbURL.Location = new System.Drawing.Point(56, 52);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(339, 20);
            this.txbURL.TabIndex = 0;
            this.txbURL.Text = "http://Demotywatory.pl";
            // 
            // txbKey
            // 
            this.txbKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbKey.Location = new System.Drawing.Point(56, 83);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(339, 20);
            this.txbKey.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(60, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 39);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Jeśli na stronie znajduje się obrazek \r\nzawierający w opisie klucz";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // layCondition
            // 
            this.layCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layCondition.BackColor = System.Drawing.SystemColors.Info;
            this.layCondition.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layCondition.ColumnCount = 2;
            this.mainLayout.SetColumnSpan(this.layCondition, 4);
            this.layCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layCondition.Controls.Add(this.textBox1, 1, 0);
            this.layCondition.Controls.Add(this.txbKey, 1, 2);
            this.layCondition.Controls.Add(this.txbURL, 1, 1);
            this.layCondition.Controls.Add(this.labURL, 0, 1);
            this.layCondition.Controls.Add(this.labKey, 0, 2);
            this.layCondition.Location = new System.Drawing.Point(90, 43);
            this.layCondition.MaximumSize = new System.Drawing.Size(400, 105);
            this.layCondition.MinimumSize = new System.Drawing.Size(400, 105);
            this.layCondition.Name = "layCondition";
            this.layCondition.RowCount = 3;
            this.layCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layCondition.Size = new System.Drawing.Size(400, 105);
            this.layCondition.TabIndex = 8;
            // 
            // combChooseCondition
            // 
            this.combChooseCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.SetColumnSpan(this.combChooseCondition, 4);
            this.combChooseCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseCondition.FormattingEnabled = true;
            this.combChooseCondition.Items.AddRange(new object[] {
            "Obrazek z kluczem w opisie na stronie"});
            this.combChooseCondition.Location = new System.Drawing.Point(127, 16);
            this.combChooseCondition.Name = "combChooseCondition";
            this.combChooseCondition.Size = new System.Drawing.Size(325, 21);
            this.combChooseCondition.TabIndex = 9;
            // 
            // txbMail
            // 
            this.txbMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMail.Location = new System.Drawing.Point(69, 52);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(326, 20);
            this.txbMail.TabIndex = 2;
            this.txbMail.Text = "flagerkamil@gmail.com";
            // 
            // labMail
            // 
            this.labMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(8, 55);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(35, 13);
            this.labMail.TabIndex = 6;
            this.labMail.Text = "Email:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.mainLayout.SetColumnSpan(this.tableLayoutPanel1, 4);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labMail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbMail, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 75);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(67, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(330, 39);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Wyślij obrazek w załączniku na podany email";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 429);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.picbTest);
            this.Name = "MainWindow";
            this.Text = "JTTT";
            ((System.ComponentModel.ISupportInitialize)(this.picbTest)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.layCondition.ResumeLayout(false);
            this.layCondition.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox picbTest;
        private System.Windows.Forms.Label labJesli;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label labToTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.ComboBox combChooseCondition;
        private System.Windows.Forms.TableLayoutPanel layCondition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label labURL;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.ComboBox combChooseAction;
        private System.Windows.Forms.Label labChooseCondition;
        private System.Windows.Forms.Label labChooseAction;
        private System.Windows.Forms.TextBox textBox2;
    }
}

