
namespace WindowsFormsApp1.Forms
{
    partial class FrmQLDT
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
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateNam = new System.Windows.Forms.TextBox();
            this.cbMaNDT = new System.Windows.Forms.ComboBox();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.txtMadoi = new System.Windows.Forms.TextBox();
            this.txtKH_ma = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDT_timkiem = new System.Windows.Forms.Button();
            this.lsvDoithi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDT_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDT_Huy = new FontAwesome.Sharp.IconButton();
            this.btnDT_Xoa = new FontAwesome.Sharp.IconButton();
            this.btnDT_Sua = new FontAwesome.Sharp.IconButton();
            this.btnDT_Them = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKetqua
            // 
            this.txtKetqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetqua.Location = new System.Drawing.Point(118, 115);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(178, 22);
            this.txtKetqua.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dateNam);
            this.groupBox2.Controls.Add(this.cbMaNDT);
            this.groupBox2.Controls.Add(this.cbMaGV);
            this.groupBox2.Controls.Add(this.txtKetqua);
            this.groupBox2.Controls.Add(this.txtMadoi);
            this.groupBox2.Controls.Add(this.txtKH_ma);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnDT_Huy);
            this.groupBox2.Controls.Add(this.btnDT_Xoa);
            this.groupBox2.Controls.Add(this.btnDT_Sua);
            this.groupBox2.Controls.Add(this.btnDT_Them);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTendoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(1109, 301);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đội thi";
            // 
            // dateNam
            // 
            this.dateNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNam.Location = new System.Drawing.Point(440, 15);
            this.dateNam.Name = "dateNam";
            this.dateNam.Size = new System.Drawing.Size(178, 22);
            this.dateNam.TabIndex = 41;
            // 
            // cbMaNDT
            // 
            this.cbMaNDT.FormattingEnabled = true;
            this.cbMaNDT.Location = new System.Drawing.Point(484, 107);
            this.cbMaNDT.Name = "cbMaNDT";
            this.cbMaNDT.Size = new System.Drawing.Size(178, 24);
            this.cbMaNDT.TabIndex = 40;
            // 
            // cbMaGV
            // 
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Location = new System.Drawing.Point(473, 43);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(178, 24);
            this.cbMaGV.TabIndex = 39;
            // 
            // txtMadoi
            // 
            this.txtMadoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMadoi.Location = new System.Drawing.Point(118, 38);
            this.txtMadoi.Name = "txtMadoi";
            this.txtMadoi.Size = new System.Drawing.Size(102, 22);
            this.txtMadoi.TabIndex = 35;
            // 
            // txtKH_ma
            // 
            this.txtKH_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ma.AutoSize = true;
            this.txtKH_ma.Location = new System.Drawing.Point(53, 28);
            this.txtKH_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKH_ma.Name = "txtKH_ma";
            this.txtKH_ma.Size = new System.Drawing.Size(0, 17);
            this.txtKH_ma.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mã nội dung thi";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mã giảng viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 38);
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
            this.label4.Location = new System.Drawing.Point(33, 117);
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
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đội";
            // 
            // txtTendoi
            // 
            this.txtTendoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTendoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTendoi.Location = new System.Drawing.Point(118, 73);
            this.txtTendoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendoi.Name = "txtTendoi";
            this.txtTendoi.Size = new System.Drawing.Size(178, 22);
            this.txtTendoi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đội";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnDT_timkiem);
            this.groupBox1.Controls.Add(this.lsvDoithi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtDT_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1129, 739);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đội thi";
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
            this.lsvDoithi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDoithi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDoithi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader7});
            this.lsvDoithi.FullRowSelect = true;
            this.lsvDoithi.GridLines = true;
            this.lsvDoithi.HideSelection = false;
            this.lsvDoithi.Location = new System.Drawing.Point(8, 59);
            this.lsvDoithi.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDoithi.Name = "lsvDoithi";
            this.lsvDoithi.Size = new System.Drawing.Size(529, 317);
            this.lsvDoithi.TabIndex = 0;
            this.lsvDoithi.UseCompatibleStateImageBehavior = false;
            this.lsvDoithi.View = System.Windows.Forms.View.Details;
            this.lsvDoithi.SelectedIndexChanged += new System.EventHandler(this.lsvDoithi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đội";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đội";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kết quả";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm";
            this.columnHeader4.Width = 72;
            // 
            // txtDT_search
            // 
            this.txtDT_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDT_search.Location = new System.Drawing.Point(143, 20);
            this.txtDT_search.Margin = new System.Windows.Forms.Padding(4);
            this.txtDT_search.Name = "txtDT_search";
            this.txtDT_search.Size = new System.Drawing.Size(250, 22);
            this.txtDT_search.TabIndex = 0;
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã giảng viên";
            this.columnHeader6.Width = 53;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên giảng viên";
            this.columnHeader8.Width = 167;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nội dung thi";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên nội dung thi";
            this.columnHeader7.Width = 149;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(547, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(525, 410);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thành viên dự thi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 54);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã đội";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên đội";
            this.columnHeader10.Width = 173;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã sinh viên";
            this.columnHeader11.Width = 88;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên sinh viên";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Kết quả";
            this.columnHeader13.Width = 53;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(143, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm";
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
            this.btnDT_Huy.Location = new System.Drawing.Point(602, 167);
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
            this.btnDT_Xoa.Location = new System.Drawing.Point(440, 167);
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
            this.btnDT_Sua.Location = new System.Drawing.Point(279, 167);
            this.btnDT_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Sua.Name = "btnDT_Sua";
            this.btnDT_Sua.Size = new System.Drawing.Size(131, 49);
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
            this.btnDT_Them.Location = new System.Drawing.Point(118, 167);
            this.btnDT_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btnDT_Them.Name = "btnDT_Them";
            this.btnDT_Them.Size = new System.Drawing.Size(131, 49);
            this.btnDT_Them.TabIndex = 20;
            this.btnDT_Them.Text = "Thêm";
            this.btnDT_Them.UseVisualStyleBackColor = true;
            this.btnDT_Them.Click += new System.EventHandler(this.btnDT_Them_Click);
            // 
            // FrmQLDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 746);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLDT";
            this.Tag = "Quản lý đội thi";
            this.Text = "Quản lý đội thi";
            this.Load += new System.EventHandler(this.FrmQLDT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMadoi;
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
        private System.Windows.Forms.TextBox txtTendoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDT_timkiem;
        private System.Windows.Forms.ListView lsvDoithi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDT_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaNDT;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.TextBox dateNam;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}