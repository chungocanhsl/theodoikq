
namespace WindowsFormsApp1.Forms
{
    partial class FrmQLDoiThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvSVDT = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaSVDT = new FontAwesome.Sharp.IconButton();
            this.btnThemSVDT = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDT_timkiem = new System.Windows.Forms.Button();
            this.lsvDoithi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDT_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.cbMaNDT = new System.Windows.Forms.ComboBox();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.dateNam = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.txtTendoi = new System.Windows.Forms.TextBox();
            this.txtMadoi = new System.Windows.Forms.TextBox();
            this.txtKH_ma = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDT_Huy = new FontAwesome.Sharp.IconButton();
            this.btnDT_Xoa = new FontAwesome.Sharp.IconButton();
            this.btnDT_Sua = new FontAwesome.Sharp.IconButton();
            this.btnDT_Them = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnDT_timkiem);
            this.groupBox1.Controls.Add(this.lsvDoithi);
            this.groupBox1.Controls.Add(this.txtDT_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(10845, 688);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đội thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lsvSVDT);
            this.groupBox2.Location = new System.Drawing.Point(520, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(10344, 304);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thành viên dự thi";
            // 
            // lsvSVDT
            // 
            this.lsvSVDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvSVDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvSVDT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsvSVDT.FullRowSelect = true;
            this.lsvSVDT.GridLines = true;
            this.lsvSVDT.HideSelection = false;
            this.lsvSVDT.Location = new System.Drawing.Point(8, 59);
            this.lsvSVDT.Margin = new System.Windows.Forms.Padding(4);
            this.lsvSVDT.Name = "lsvSVDT";
            this.lsvSVDT.Size = new System.Drawing.Size(3825, 229);
            this.lsvSVDT.TabIndex = 0;
            this.lsvSVDT.UseCompatibleStateImageBehavior = false;
            this.lsvSVDT.View = System.Windows.Forms.View.Details;
            this.lsvSVDT.SelectedIndexChanged += new System.EventHandler(this.lsvSVDT_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã đội";
            this.columnHeader9.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên đội";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã sinh viên";
            this.columnHeader11.Width = 72;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên sinh viên";
            this.columnHeader12.Width = 121;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Kết quả dự thi";
            this.columnHeader13.Width = 118;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.cbSV);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnXoaSVDT);
            this.groupBox4.Controls.Add(this.btnThemSVDT);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(536, 325);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(493, 351);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin thành viên dự thi";
            // 
            // cbSV
            // 
            this.cbSV.FormattingEnabled = true;
            this.cbSV.Location = new System.Drawing.Point(153, 115);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(145, 24);
            this.cbSV.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-255, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 34;
            // 
            // btnXoaSVDT
            // 
            this.btnXoaSVDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaSVDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSVDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaSVDT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaSVDT.IconColor = System.Drawing.Color.Black;
            this.btnXoaSVDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaSVDT.IconSize = 25;
            this.btnXoaSVDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSVDT.Location = new System.Drawing.Point(222, 279);
            this.btnXoaSVDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSVDT.Name = "btnXoaSVDT";
            this.btnXoaSVDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoaSVDT.Size = new System.Drawing.Size(119, 49);
            this.btnXoaSVDT.TabIndex = 22;
            this.btnXoaSVDT.Text = "Xóa";
            this.btnXoaSVDT.UseVisualStyleBackColor = true;
            this.btnXoaSVDT.Click += new System.EventHandler(this.btnXoaSVDT_Click);
            // 
            // btnThemSVDT
            // 
            this.btnThemSVDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSVDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSVDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemSVDT.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThemSVDT.IconColor = System.Drawing.Color.Black;
            this.btnThemSVDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSVDT.IconSize = 25;
            this.btnThemSVDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSVDT.Location = new System.Drawing.Point(65, 278);
            this.btnThemSVDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSVDT.Name = "btnThemSVDT";
            this.btnThemSVDT.Size = new System.Drawing.Size(106, 49);
            this.btnThemSVDT.TabIndex = 20;
            this.btnThemSVDT.Text = "Thêm";
            this.btnThemSVDT.UseVisualStyleBackColor = true;
            this.btnThemSVDT.Click += new System.EventHandler(this.btnThemSVDT_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 116);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sinh viên";
            // 
            // btnDT_timkiem
            // 
            this.btnDT_timkiem.Location = new System.Drawing.Point(401, 18);
            this.btnDT_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_timkiem.Name = "btnDT_timkiem";
            this.btnDT_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btnDT_timkiem.TabIndex = 2;
            this.btnDT_timkiem.Text = "Tìm kiếm";
            this.btnDT_timkiem.UseVisualStyleBackColor = true;
            this.btnDT_timkiem.Click += new System.EventHandler(this.btnDT_timkiem_Click);
            // 
            // lsvDoithi
            // 
            this.lsvDoithi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDoithi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader7});
            this.lsvDoithi.FullRowSelect = true;
            this.lsvDoithi.GridLines = true;
            this.lsvDoithi.HideSelection = false;
            this.lsvDoithi.Location = new System.Drawing.Point(-4, 59);
            this.lsvDoithi.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDoithi.Name = "lsvDoithi";
            this.lsvDoithi.Size = new System.Drawing.Size(524, 245);
            this.lsvDoithi.TabIndex = 0;
            this.lsvDoithi.UseCompatibleStateImageBehavior = false;
            this.lsvDoithi.View = System.Windows.Forms.View.Details;
            this.lsvDoithi.SelectedIndexChanged += new System.EventHandler(this.lsvDoithi_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đội";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đội";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kết quả";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên giảng viên";
            this.columnHeader8.Width = 167;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên nội dung thi";
            this.columnHeader7.Width = 149;
            // 
            // txtDT_search
            // 
            this.txtDT_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDT_search.Location = new System.Drawing.Point(143, 20);
            this.txtDT_search.Margin = new System.Windows.Forms.Padding(4);
            this.txtDT_search.Name = "txtDT_search";
            this.txtDT_search.Size = new System.Drawing.Size(250, 22);
            this.txtDT_search.TabIndex = 0;
            this.txtDT_search.TextChanged += new System.EventHandler(this.txtDT_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.cbMaNDT);
            this.groupBox3.Controls.Add(this.cbMaGV);
            this.groupBox3.Controls.Add(this.dateNam);
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Controls.Add(this.txtTendoi);
            this.groupBox3.Controls.Add(this.txtMadoi);
            this.groupBox3.Controls.Add(this.txtKH_ma);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnDT_Huy);
            this.groupBox3.Controls.Add(this.btnDT_Xoa);
            this.groupBox3.Controls.Add(this.btnDT_Sua);
            this.groupBox3.Controls.Add(this.btnDT_Them);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 325);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(528, 387);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đội thi";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnLuu.IconColor = System.Drawing.Color.Black;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 25;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(-1, 284);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 47);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbMaNDT
            // 
            this.cbMaNDT.FormattingEnabled = true;
            this.cbMaNDT.Location = new System.Drawing.Point(361, 163);
            this.cbMaNDT.Name = "cbMaNDT";
            this.cbMaNDT.Size = new System.Drawing.Size(128, 24);
            this.cbMaNDT.TabIndex = 44;
            // 
            // cbMaGV
            // 
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Location = new System.Drawing.Point(361, 122);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(128, 24);
            this.cbMaGV.TabIndex = 43;
            // 
            // dateNam
            // 
            this.dateNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNam.Location = new System.Drawing.Point(354, 76);
            this.dateNam.Name = "dateNam";
            this.dateNam.Size = new System.Drawing.Size(128, 22);
            this.dateNam.TabIndex = 42;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetqua.Location = new System.Drawing.Point(101, 160);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(102, 22);
            this.txtKetqua.TabIndex = 41;
            // 
            // txtTendoi
            // 
            this.txtTendoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTendoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTendoi.Location = new System.Drawing.Point(101, 119);
            this.txtTendoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendoi.Name = "txtTendoi";
            this.txtTendoi.Size = new System.Drawing.Size(102, 22);
            this.txtTendoi.TabIndex = 40;
            // 
            // txtMadoi
            // 
            this.txtMadoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMadoi.Location = new System.Drawing.Point(101, 78);
            this.txtMadoi.Name = "txtMadoi";
            this.txtMadoi.Size = new System.Drawing.Size(102, 22);
            this.txtMadoi.TabIndex = 39;
            // 
            // txtKH_ma
            // 
            this.txtKH_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ma.AutoSize = true;
            this.txtKH_ma.Location = new System.Drawing.Point(-237, 71);
            this.txtKH_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKH_ma.Name = "txtKH_ma";
            this.txtKH_ma.Size = new System.Drawing.Size(0, 17);
            this.txtKH_ma.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nội dung thi";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Giảng viên";
            // 
            // btnDT_Huy
            // 
            this.btnDT_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDT_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDT_Huy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnDT_Huy.IconColor = System.Drawing.Color.Black;
            this.btnDT_Huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDT_Huy.IconSize = 25;
            this.btnDT_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDT_Huy.Location = new System.Drawing.Point(390, 282);
            this.btnDT_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Huy.Name = "btnDT_Huy";
            this.btnDT_Huy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDT_Huy.Size = new System.Drawing.Size(131, 49);
            this.btnDT_Huy.TabIndex = 23;
            this.btnDT_Huy.Text = "Hủy";
            this.btnDT_Huy.UseVisualStyleBackColor = true;
            this.btnDT_Huy.Click += new System.EventHandler(this.btnDT_Huy_Click);
            // 
            // btnDT_Xoa
            // 
            this.btnDT_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDT_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDT_Xoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDT_Xoa.IconColor = System.Drawing.Color.Black;
            this.btnDT_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDT_Xoa.IconSize = 25;
            this.btnDT_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDT_Xoa.Location = new System.Drawing.Point(237, 282);
            this.btnDT_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Xoa.Name = "btnDT_Xoa";
            this.btnDT_Xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDT_Xoa.Size = new System.Drawing.Size(131, 49);
            this.btnDT_Xoa.TabIndex = 22;
            this.btnDT_Xoa.Text = "Xóa";
            this.btnDT_Xoa.UseVisualStyleBackColor = true;
            this.btnDT_Xoa.Click += new System.EventHandler(this.btnDT_Xoa_Click);
            // 
            // btnDT_Sua
            // 
            this.btnDT_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDT_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDT_Sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnDT_Sua.IconColor = System.Drawing.Color.Black;
            this.btnDT_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDT_Sua.IconSize = 25;
            this.btnDT_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDT_Sua.Location = new System.Drawing.Point(115, 282);
            this.btnDT_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Sua.Name = "btnDT_Sua";
            this.btnDT_Sua.Size = new System.Drawing.Size(105, 49);
            this.btnDT_Sua.TabIndex = 21;
            this.btnDT_Sua.Text = "Sửa";
            this.btnDT_Sua.UseVisualStyleBackColor = true;
            this.btnDT_Sua.Click += new System.EventHandler(this.btnDT_Sua_Click);
            // 
            // btnDT_Them
            // 
            this.btnDT_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDT_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDT_Them.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnDT_Them.IconColor = System.Drawing.Color.Black;
            this.btnDT_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDT_Them.IconSize = 25;
            this.btnDT_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDT_Them.Location = new System.Drawing.Point(1, 282);
            this.btnDT_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Them.Name = "btnDT_Them";
            this.btnDT_Them.Size = new System.Drawing.Size(104, 49);
            this.btnDT_Them.TabIndex = 20;
            this.btnDT_Them.Text = "Thêm";
            this.btnDT_Them.UseVisualStyleBackColor = true;
            this.btnDT_Them.Click += new System.EventHandler(this.btnDT_Them_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đội";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã đội";
            // 
            // FrmQLDoiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 688);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLDoiThi";
            this.Text = "Quản lý đội thi";
            this.Load += new System.EventHandler(this.FrmQLDoiThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDT_timkiem;
        private System.Windows.Forms.ListView lsvDoithi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtDT_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvSVDT;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtKH_ma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnDT_Huy;
        private FontAwesome.Sharp.IconButton btnDT_Xoa;
        private FontAwesome.Sharp.IconButton btnDT_Sua;
        private FontAwesome.Sharp.IconButton btnDT_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnXoaSVDT;
        private FontAwesome.Sharp.IconButton btnThemSVDT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMadoi;
        private System.Windows.Forms.TextBox txtTendoi;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.TextBox dateNam;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.ComboBox cbMaNDT;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.ComboBox cbSV;
    }
}