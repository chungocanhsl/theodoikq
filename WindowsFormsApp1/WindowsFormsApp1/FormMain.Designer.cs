
namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnBaocao = new FontAwesome.Sharp.IconButton();
            this.btnQLDT = new FontAwesome.Sharp.IconButton();
            this.btnQLND = new FontAwesome.Sharp.IconButton();
            this.btnQLSV = new FontAwesome.Sharp.IconButton();
            this.btnQLGV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnBaocao);
            this.panelMenu.Controls.Add(this.btnQLDT);
            this.panelMenu.Controls.Add(this.btnQLND);
            this.panelMenu.Controls.Add(this.btnQLSV);
            this.panelMenu.Controls.Add(this.btnQLGV);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(232, 716);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 557);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(232, 87);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Tag = "Đăng xuất";
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaocao.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnBaocao.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBaocao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(0, 470);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(232, 87);
            this.btnBaocao.TabIndex = 5;
            this.btnBaocao.Tag = "Báo cáo thống kê";
            this.btnBaocao.Text = "Báo cáo thống kê";
            this.btnBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnQLDT
            // 
            this.btnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDT.FlatAppearance.BorderSize = 0;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDT.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnQLDT.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.Location = new System.Drawing.Point(0, 383);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Size = new System.Drawing.Size(232, 87);
            this.btnQLDT.TabIndex = 4;
            this.btnQLDT.Tag = "Quản lý đội thi";
            this.btnQLDT.Text = "Quản lý đội thi";
            this.btnQLDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click);
            // 
            // btnQLND
            // 
            this.btnQLND.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLND.FlatAppearance.BorderSize = 0;
            this.btnQLND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLND.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLND.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQLND.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLND.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLND.Location = new System.Drawing.Point(0, 296);
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.Size = new System.Drawing.Size(232, 87);
            this.btnQLND.TabIndex = 3;
            this.btnQLND.Tag = "Quản lý nội dung thi";
            this.btnQLND.Text = "Quản lý nội dung thi";
            this.btnQLND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLND.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLND.UseVisualStyleBackColor = true;
            this.btnQLND.Click += new System.EventHandler(this.btnQLND_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSV.FlatAppearance.BorderSize = 0;
            this.btnQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLSV.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnQLSV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSV.Location = new System.Drawing.Point(0, 209);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(232, 87);
            this.btnQLSV.TabIndex = 2;
            this.btnQLSV.Tag = "Quản lý sinh viên";
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLGV.FlatAppearance.BorderSize = 0;
            this.btnQLGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLGV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLGV.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnQLGV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLGV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLGV.Location = new System.Drawing.Point(0, 122);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(232, 87);
            this.btnQLGV.TabIndex = 1;
            this.btnQLGV.Tag = "Quản lý giảng viên";
            this.btnQLGV.Text = "Quản lý giảng viên";
            this.btnQLGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLGV.UseVisualStyleBackColor = true;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(232, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.lblTitleChildForm);
            this.panelTitle.Controls.Add(this.iconCurrentChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(232, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(922, 62);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(889, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(65, 18);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(602, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Hệ thống theo dõi kết quả các kỳ thi Olympic của sinh viên khoa CNTT";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.LightCoral;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.LightCoral;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(232, 62);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(922, 654);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.anh;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 716);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnBaocao;
        private FontAwesome.Sharp.IconButton btnQLDT;
        private FontAwesome.Sharp.IconButton btnQLND;
        private FontAwesome.Sharp.IconButton btnQLSV;
        private FontAwesome.Sharp.IconButton btnQLGV;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}