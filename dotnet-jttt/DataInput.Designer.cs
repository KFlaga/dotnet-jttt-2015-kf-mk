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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.txbTitle, 1, 0);
            this.mainLayout.Location = new System.Drawing.Point(5, 5);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(5);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(400, 45);
            this.mainLayout.TabIndex = 0;
            // 
            // txbTitle
            // 
            this.txbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTitle.BackColor = System.Drawing.SystemColors.Info;
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbTitle.Location = new System.Drawing.Point(55, 3);
            this.txbTitle.Multiline = true;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.ReadOnly = true;
            this.txbTitle.Size = new System.Drawing.Size(330, 39);
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
            this.Controls.Add(this.mainLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataInput";
            this.Size = new System.Drawing.Size(410, 55);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TextBox txbTitle;

    }
}
