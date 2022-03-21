
namespace WindowsFormsApp1.ChildForm
{
    partial class FrmQLGV
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
            this.btnGV_timkiem = new System.Windows.Forms.Button();
            this.txtGV_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvGiangVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT_GV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.txtGV_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGV_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGV_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ns_GV = new System.Windows.Forms.DateTimePicker();
            this.txtKH_ma = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.btnGV_Huy = new FontAwesome.Sharp.IconButton();
            this.btnGV_Xoa = new FontAwesome.Sharp.IconButton();
            this.btnGV_Sua = new FontAwesome.Sharp.IconButton();
            this.btnGV_Them = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGV_timkiem
            // 
            this.btnGV_timkiem.Location = new System.Drawing.Point(399, 18);
            this.btnGV_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV_timkiem.Name = "btnGV_timkiem";
            this.btnGV_timkiem.Size = new System.Drawing.Size(108, 28);
            this.btnGV_timkiem.TabIndex = 2;
            this.btnGV_timkiem.Text = "Tìm kiếm";
            this.btnGV_timkiem.UseVisualStyleBackColor = true;
            this.btnGV_timkiem.Click += new System.EventHandler(this.btnGV_timkiem_Click);
            // 
            // txtGV_search
            // 
            this.txtGV_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGV_search.Location = new System.Drawing.Point(141, 20);
            this.txtGV_search.Margin = new System.Windows.Forms.Padding(4);
            this.txtGV_search.Name = "txtGV_search";
            this.txtGV_search.Size = new System.Drawing.Size(176, 22);
            this.txtGV_search.TabIndex = 0;
            this.txtGV_search.TextChanged += new System.EventHandler(this.txtGV_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnGV_timkiem);
            this.groupBox1.Controls.Add(this.lsvGiangVien);
            this.groupBox1.Controls.Add(this.txtGV_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1074, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giảng viên";
            // 
            // lsvGiangVien
            // 
            this.lsvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvGiangVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvGiangVien.FullRowSelect = true;
            this.lsvGiangVien.GridLines = true;
            this.lsvGiangVien.HideSelection = false;
            this.lsvGiangVien.Location = new System.Drawing.Point(14, 54);
            this.lsvGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.lsvGiangVien.Name = "lsvGiangVien";
            this.lsvGiangVien.Size = new System.Drawing.Size(1055, 280);
            this.lsvGiangVien.TabIndex = 0;
            this.lsvGiangVien.UseCompatibleStateImageBehavior = false;
            this.lsvGiangVien.View = System.Windows.Forms.View.Details;
            this.lsvGiangVien.SelectedIndexChanged += new System.EventHandler(this.lsvGiangVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giảng viên";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên tài khoản";
            this.columnHeader9.Width = 137;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mật khẩu";
            this.columnHeader10.Width = 134;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã giảng viên:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenGV.Location = new System.Drawing.Point(289, 88);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(147, 22);
            this.txtTenGV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // txtSDT_GV
            // 
            this.txtSDT_GV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT_GV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT_GV.Location = new System.Drawing.Point(289, 192);
            this.txtSDT_GV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT_GV.Name = "txtSDT_GV";
            this.txtSDT_GV.Size = new System.Drawing.Size(147, 22);
            this.txtSDT_GV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // cbGV
            // 
            this.cbGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGV.Location = new System.Drawing.Point(289, 138);
            this.cbGV.Margin = new System.Windows.Forms.Padding(4);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(115, 24);
            this.cbGV.TabIndex = 3;
            // 
            // txtGV_username
            // 
            this.txtGV_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGV_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGV_username.Location = new System.Drawing.Point(693, 138);
            this.txtGV_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtGV_username.Name = "txtGV_username";
            this.txtGV_username.Size = new System.Drawing.Size(102, 22);
            this.txtGV_username.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Username";
            // 
            // txtGV_pass
            // 
            this.txtGV_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGV_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGV_pass.Location = new System.Drawing.Point(693, 194);
            this.txtGV_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txtGV_pass.Name = "txtGV_pass";
            this.txtGV_pass.Size = new System.Drawing.Size(98, 22);
            this.txtGV_pass.TabIndex = 8;
            this.txtGV_pass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ngày sinh:";
            // 
            // txtGV_email
            // 
            this.txtGV_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGV_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGV_email.Location = new System.Drawing.Point(693, 83);
            this.txtGV_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtGV_email.Name = "txtGV_email";
            this.txtGV_email.Size = new System.Drawing.Size(102, 22);
            this.txtGV_email.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Email";
            // 
            // ns_GV
            // 
            this.ns_GV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ns_GV.CustomFormat = "";
            this.ns_GV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ns_GV.Location = new System.Drawing.Point(693, 42);
            this.ns_GV.Margin = new System.Windows.Forms.Padding(4);
            this.ns_GV.Name = "ns_GV";
            this.ns_GV.Size = new System.Drawing.Size(147, 22);
            this.ns_GV.TabIndex = 5;
            // 
            // txtKH_ma
            // 
            this.txtKH_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ma.AutoSize = true;
            this.txtKH_ma.Location = new System.Drawing.Point(1, 45);
            this.txtKH_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKH_ma.Name = "txtKH_ma";
            this.txtKH_ma.Size = new System.Drawing.Size(0, 17);
            this.txtKH_ma.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.txtKH_ma);
            this.groupBox2.Controls.Add(this.ns_GV);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGV_email);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnGV_Huy);
            this.groupBox2.Controls.Add(this.btnGV_Xoa);
            this.groupBox2.Controls.Add(this.btnGV_Sua);
            this.groupBox2.Controls.Add(this.btnGV_Them);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGV_pass);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGV_username);
            this.groupBox2.Controls.Add(this.cbGV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSDT_GV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 356);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1069, 332);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giảng viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaGV.Location = new System.Drawing.Point(289, 36);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(147, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // btnGV_Huy
            // 
            this.btnGV_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGV_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGV_Huy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnGV_Huy.IconColor = System.Drawing.Color.Black;
            this.btnGV_Huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGV_Huy.IconSize = 25;
            this.btnGV_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGV_Huy.Location = new System.Drawing.Point(668, 256);
            this.btnGV_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV_Huy.Name = "btnGV_Huy";
            this.btnGV_Huy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGV_Huy.Size = new System.Drawing.Size(106, 53);
            this.btnGV_Huy.TabIndex = 23;
            this.btnGV_Huy.Text = "Hủy";
            this.btnGV_Huy.UseVisualStyleBackColor = true;
            this.btnGV_Huy.Click += new System.EventHandler(this.btnGV_Huy_Click);
            // 
            // btnGV_Xoa
            // 
            this.btnGV_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGV_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGV_Xoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnGV_Xoa.IconColor = System.Drawing.Color.Black;
            this.btnGV_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGV_Xoa.IconSize = 25;
            this.btnGV_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGV_Xoa.Location = new System.Drawing.Point(561, 256);
            this.btnGV_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV_Xoa.Name = "btnGV_Xoa";
            this.btnGV_Xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGV_Xoa.Size = new System.Drawing.Size(99, 53);
            this.btnGV_Xoa.TabIndex = 22;
            this.btnGV_Xoa.Text = "Xóa";
            this.btnGV_Xoa.UseVisualStyleBackColor = true;
            this.btnGV_Xoa.Click += new System.EventHandler(this.btnGV_Xoa_Click);
            // 
            // btnGV_Sua
            // 
            this.btnGV_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGV_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGV_Sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnGV_Sua.IconColor = System.Drawing.Color.Black;
            this.btnGV_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGV_Sua.IconSize = 25;
            this.btnGV_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGV_Sua.Location = new System.Drawing.Point(431, 256);
            this.btnGV_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV_Sua.Name = "btnGV_Sua";
            this.btnGV_Sua.Size = new System.Drawing.Size(122, 53);
            this.btnGV_Sua.TabIndex = 21;
            this.btnGV_Sua.Text = "Sửa";
            this.btnGV_Sua.UseVisualStyleBackColor = true;
            this.btnGV_Sua.Click += new System.EventHandler(this.btnGV_Sua_Click);
            // 
            // btnGV_Them
            // 
            this.btnGV_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGV_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGV_Them.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnGV_Them.IconColor = System.Drawing.Color.Black;
            this.btnGV_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGV_Them.IconSize = 25;
            this.btnGV_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGV_Them.Location = new System.Drawing.Point(306, 256);
            this.btnGV_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV_Them.Name = "btnGV_Them";
            this.btnGV_Them.Size = new System.Drawing.Size(117, 53);
            this.btnGV_Them.TabIndex = 20;
            this.btnGV_Them.Text = "Thêm";
            this.btnGV_Them.UseVisualStyleBackColor = true;
            this.btnGV_Them.Click += new System.EventHandler(this.btnGV_Them_Click);
            // 
            // FrmQLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmQLGV";
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.FrmQLGV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGV_timkiem;
        private System.Windows.Forms.TextBox txtGV_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvGiangVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT_GV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.TextBox txtGV_username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGV_pass;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnGV_Them;
        private FontAwesome.Sharp.IconButton btnGV_Sua;
        private FontAwesome.Sharp.IconButton btnGV_Xoa;
        private FontAwesome.Sharp.IconButton btnGV_Huy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGV_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ns_GV;
        private System.Windows.Forms.Label txtKH_ma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaGV;
    }
}