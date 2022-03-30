
namespace WindowsFormsApp1.Forms
{
    partial class FrmTKBC
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSV = new System.Windows.Forms.ComboBox();
            this.btnTKNDT = new FontAwesome.Sharp.IconButton();
            this.cbNDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTKSV = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNam = new FontAwesome.Sharp.IconButton();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(863, 686);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.btnNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSV);
            this.groupBox1.Controls.Add(this.btnTKNDT);
            this.groupBox1.Controls.Add(this.cbNDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTKSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(860, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 686);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê báo cáo";
            // 
            // cbSV
            // 
            this.cbSV.FormattingEnabled = true;
            this.cbSV.Location = new System.Drawing.Point(0, 274);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(229, 24);
            this.cbSV.TabIndex = 8;
            this.cbSV.SelectedIndexChanged += new System.EventHandler(this.cbSV_SelectedIndexChanged);
            // 
            // btnTKNDT
            // 
            this.btnTKNDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTKNDT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTKNDT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTKNDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKNDT.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnTKNDT.IconColor = System.Drawing.Color.Crimson;
            this.btnTKNDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKNDT.IconSize = 25;
            this.btnTKNDT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTKNDT.Location = new System.Drawing.Point(16, 572);
            this.btnTKNDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKNDT.Name = "btnTKNDT";
            this.btnTKNDT.Size = new System.Drawing.Size(228, 22);
            this.btnTKNDT.TabIndex = 6;
            this.btnTKNDT.Text = "      Thống kê";
            this.btnTKNDT.UseVisualStyleBackColor = true;
            this.btnTKNDT.Click += new System.EventHandler(this.btnTKNDT_Click);
            // 
            // cbNDT
            // 
            this.cbNDT.FormattingEnabled = true;
            this.cbNDT.Location = new System.Drawing.Point(16, 526);
            this.cbNDT.Name = "cbNDT";
            this.cbNDT.Size = new System.Drawing.Size(229, 24);
            this.cbNDT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nội dung thi";
            // 
            // btnTKSV
            // 
            this.btnTKSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTKSV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTKSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTKSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKSV.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnTKSV.IconColor = System.Drawing.Color.SteelBlue;
            this.btnTKSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKSV.IconSize = 25;
            this.btnTKSV.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTKSV.Location = new System.Drawing.Point(0, 342);
            this.btnTKSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKSV.Name = "btnTKSV";
            this.btnTKSV.Size = new System.Drawing.Size(228, 22);
            this.btnTKSV.TabIndex = 3;
            this.btnTKSV.Text = "      Thống kê";
            this.btnTKSV.UseVisualStyleBackColor = true;
            this.btnTKSV.Click += new System.EventHandler(this.btnTKSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Năm";
            // 
            // btnNam
            // 
            this.btnNam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnNam.IconColor = System.Drawing.Color.SteelBlue;
            this.btnNam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNam.IconSize = 25;
            this.btnNam.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNam.Location = new System.Drawing.Point(9, 134);
            this.btnNam.Margin = new System.Windows.Forms.Padding(4);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(228, 22);
            this.btnNam.TabIndex = 11;
            this.btnNam.Text = "      Thống kê";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnTKNam_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(9, 81);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(229, 24);
            this.cbNam.TabIndex = 58;
            // 
            // FrmTKBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmTKBC";
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.FrmTKBC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNDT;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnTKSV;
        private FontAwesome.Sharp.IconButton btnTKNDT;
        private System.Windows.Forms.ComboBox cbSV;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnNam;
        private System.Windows.Forms.ComboBox cbNam;
    }
}