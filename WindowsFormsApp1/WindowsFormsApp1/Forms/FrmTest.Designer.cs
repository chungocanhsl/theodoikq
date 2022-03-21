
namespace WindowsFormsApp1.Forms
{
    partial class FrmTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbSV
            // 
            this.cbSV.FormattingEnabled = true;
            this.cbSV.Location = new System.Drawing.Point(369, 132);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(145, 24);
            this.cbSV.TabIndex = 47;
            this.cbSV.SelectedIndexChanged += new System.EventHandler(this.cbSV_SelectedIndexChanged);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSV);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSV;
    }
}