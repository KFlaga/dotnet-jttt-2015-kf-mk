namespace dotnet_jttt
{
    partial class DataInput
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbTitle
            // 
            this.txbTitle.BackColor = System.Drawing.SystemColors.Info;
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbTitle.Location = new System.Drawing.Point(0, 0);
            this.txbTitle.MaximumSize = new System.Drawing.Size(410, 45);
            this.txbTitle.Multiline = true;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.ReadOnly = true;
            this.txbTitle.Size = new System.Drawing.Size(410, 39);
            this.txbTitle.TabIndex = 14;
            this.txbTitle.Text = "empty\r\nempty";
            this.txbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txbTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataInput";
            this.Size = new System.Drawing.Size(410, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTitle;


    }
}
