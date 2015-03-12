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
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.labURL = new System.Windows.Forms.Label();
            this.labKey = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.picbTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(147, 127);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(270, 20);
            this.txbURL.TabIndex = 0;
            this.txbURL.Text = "http://Demotywatory.pl";
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(147, 164);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(270, 20);
            this.txbKey.TabIndex = 1;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(147, 296);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(270, 20);
            this.txbMail.TabIndex = 2;
            this.txbMail.Text = "flagerkamil@gmail.com";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(203, 364);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(164, 41);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Start";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // labURL
            // 
            this.labURL.AutoSize = true;
            this.labURL.Location = new System.Drawing.Point(109, 130);
            this.labURL.Name = "labURL";
            this.labURL.Size = new System.Drawing.Size(32, 13);
            this.labURL.TabIndex = 4;
            this.labURL.Text = "URL:";
            // 
            // labKey
            // 
            this.labKey.AutoSize = true;
            this.labKey.Location = new System.Drawing.Point(105, 167);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(36, 13);
            this.labKey.TabIndex = 5;
            this.labKey.Text = "Klucz:";
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(105, 299);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(35, 13);
            this.labMail.TabIndex = 6;
            this.labMail.Text = "Email:";
            // 
            // picbTest
            // 
            this.picbTest.Location = new System.Drawing.Point(122, 22);
            this.picbTest.Name = "picbTest";
            this.picbTest.Size = new System.Drawing.Size(311, 85);
            this.picbTest.TabIndex = 7;
            this.picbTest.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 429);
            this.Controls.Add(this.picbTest);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.labKey);
            this.Controls.Add(this.labURL);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.txbURL);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label labURL;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.PictureBox picbTest;
    }
}

