
namespace WindowsFormsApp1.Forms
{
    partial class FrmQLND
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
            this.txtMaNDThi = new System.Windows.Forms.TextBox();
            this.txtKH_ma = new System.Windows.Forms.Label();
            this.dateNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNDT_Huy = new FontAwesome.Sharp.IconButton();
            this.btnNDT_Xoa = new FontAwesome.Sharp.IconButton();
            this.btnNDT_Sua = new FontAwesome.Sharp.IconButton();
            this.btnNDT_Them = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNDThi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.dateNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txtDiadiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNDT_timkiem = new System.Windows.Forms.Button();
            this.lsvNoidungthi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNDT_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaNDThi
            // 
            this.txtMaNDThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNDThi.Location = new System.Drawing.Point(314, 46);
            this.txtMaNDThi.Name = "txtMaNDThi";
            this.txtMaNDThi.Size = new System.Drawing.Size(178, 22);
            this.txtMaNDThi.TabIndex = 35;
            // 
            // txtKH_ma
            // 
            this.txtKH_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ma.AutoSize = true;
            this.txtKH_ma.Location = new System.Drawing.Point(33, 38);
            this.txtKH_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKH_ma.Name = "txtKH_ma";
            this.txtKH_ma.Size = new System.Drawing.Size(0, 17);
            this.txtKH_ma.TabIndex = 34;
            // 
            // dateNgayketthuc
            // 
            this.dateNgayketthuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNgayketthuc.CustomFormat = "";
            this.dateNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayketthuc.Location = new System.Drawing.Point(685, 84);
            this.dateNgayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayketthuc.Name = "dateNgayketthuc";
            this.dateNgayketthuc.Size = new System.Drawing.Size(246, 22);
            this.dateNgayketthuc.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Địa điểm";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(548, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ngày kết thúc";
            // 
            // btnNDT_Huy
            // 
            this.btnNDT_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNDT_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNDT_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNDT_Huy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnNDT_Huy.IconColor = System.Drawing.Color.Black;
            this.btnNDT_Huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNDT_Huy.IconSize = 25;
            this.btnNDT_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNDT_Huy.Location = new System.Drawing.Point(762, 249);
            this.btnNDT_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.btnNDT_Huy.Name = "btnNDT_Huy";
            this.btnNDT_Huy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNDT_Huy.Size = new System.Drawing.Size(131, 49);
            this.btnNDT_Huy.TabIndex = 23;
            this.btnNDT_Huy.Text = "Hủy";
            this.btnNDT_Huy.UseVisualStyleBackColor = true;
            this.btnNDT_Huy.Click += new System.EventHandler(this.btnNDT_Huy_Click);
            // 
            // btnNDT_Xoa
            // 
            this.btnNDT_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNDT_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNDT_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNDT_Xoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnNDT_Xoa.IconColor = System.Drawing.Color.Black;
            this.btnNDT_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNDT_Xoa.IconSize = 25;
            this.btnNDT_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNDT_Xoa.Location = new System.Drawing.Point(614, 249);
            this.btnNDT_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNDT_Xoa.Name = "btnNDT_Xoa";
            this.btnNDT_Xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNDT_Xoa.Size = new System.Drawing.Size(131, 49);
            this.btnNDT_Xoa.TabIndex = 22;
            this.btnNDT_Xoa.Text = "Xóa";
            this.btnNDT_Xoa.UseVisualStyleBackColor = true;
            this.btnNDT_Xoa.Click += new System.EventHandler(this.btnNDT_Xoa_Click);
            // 
            // btnNDT_Sua
            // 
            this.btnNDT_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNDT_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNDT_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNDT_Sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnNDT_Sua.IconColor = System.Drawing.Color.Black;
            this.btnNDT_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNDT_Sua.IconSize = 25;
            this.btnNDT_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNDT_Sua.Location = new System.Drawing.Point(459, 249);
            this.btnNDT_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btnNDT_Sua.Name = "btnNDT_Sua";
            this.btnNDT_Sua.Size = new System.Drawing.Size(131, 49);
            this.btnNDT_Sua.TabIndex = 21;
            this.btnNDT_Sua.Text = "Sửa";
            this.btnNDT_Sua.UseVisualStyleBackColor = true;
            this.btnNDT_Sua.Click += new System.EventHandler(this.btnNDT_Sua_Click);
            // 
            // btnNDT_Them
            // 
            this.btnNDT_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNDT_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNDT_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNDT_Them.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnNDT_Them.IconColor = System.Drawing.Color.Black;
            this.btnNDT_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNDT_Them.IconSize = 25;
            this.btnNDT_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNDT_Them.Location = new System.Drawing.Point(308, 249);
            this.btnNDT_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btnNDT_Them.Name = "btnNDT_Them";
            this.btnNDT_Them.Size = new System.Drawing.Size(131, 49);
            this.btnNDT_Them.TabIndex = 20;
            this.btnNDT_Them.Text = "Thêm";
            this.btnNDT_Them.UseVisualStyleBackColor = true;
            this.btnNDT_Them.Click += new System.EventHandler(this.btnNDT_Them_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nội dung thi";
            // 
            // txtTenNDThi
            // 
            this.txtTenNDThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNDThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNDThi.Location = new System.Drawing.Point(314, 84);
            this.txtTenNDThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNDThi.Name = "txtTenNDThi";
            this.txtTenNDThi.Size = new System.Drawing.Size(178, 22);
            this.txtTenNDThi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nội dung thi";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtMota);
            this.groupBox2.Controls.Add(this.dateNgaybatdau);
            this.groupBox2.Controls.Add(this.txtDiadiem);
            this.groupBox2.Controls.Add(this.txtMaNDThi);
            this.groupBox2.Controls.Add(this.txtKH_ma);
            this.groupBox2.Controls.Add(this.dateNgayketthuc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnNDT_Huy);
            this.groupBox2.Controls.Add(this.btnNDT_Xoa);
            this.groupBox2.Controls.Add(this.btnNDT_Sua);
            this.groupBox2.Controls.Add(this.btnNDT_Them);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenNDThi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1069, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nội dung thi";
            // 
            // txtMota
            // 
            this.txtMota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMota.Location = new System.Drawing.Point(314, 125);
            this.txtMota.Margin = new System.Windows.Forms.Padding(4);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(178, 22);
            this.txtMota.TabIndex = 38;
            // 
            // dateNgaybatdau
            // 
            this.dateNgaybatdau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNgaybatdau.CustomFormat = "";
            this.dateNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaybatdau.Location = new System.Drawing.Point(685, 46);
            this.dateNgaybatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaybatdau.Name = "dateNgaybatdau";
            this.dateNgaybatdau.Size = new System.Drawing.Size(246, 22);
            this.dateNgaybatdau.TabIndex = 37;
            // 
            // txtDiadiem
            // 
            this.txtDiadiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiadiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiadiem.Location = new System.Drawing.Point(685, 122);
            this.txtDiadiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiadiem.Name = "txtDiadiem";
            this.txtDiadiem.Size = new System.Drawing.Size(246, 22);
            this.txtDiadiem.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnNDT_timkiem);
            this.groupBox1.Controls.Add(this.lsvNoidungthi);
            this.groupBox1.Controls.Add(this.txtNDT_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1138, 352);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nội dung thi";
            // 
            // btnNDT_timkiem
            // 
            this.btnNDT_timkiem.Location = new System.Drawing.Point(401, 18);
            this.btnNDT_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNDT_timkiem.Name = "btnNDT_timkiem";
            this.btnNDT_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btnNDT_timkiem.TabIndex = 2;
            this.btnNDT_timkiem.Text = "Tìm kiếm";
            this.btnNDT_timkiem.UseVisualStyleBackColor = true;
            this.btnNDT_timkiem.Click += new System.EventHandler(this.btnNDT_timkiem_Click);
            // 
            // lsvNoidungthi
            // 
            this.lsvNoidungthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvNoidungthi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvNoidungthi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvNoidungthi.FullRowSelect = true;
            this.lsvNoidungthi.GridLines = true;
            this.lsvNoidungthi.HideSelection = false;
            this.lsvNoidungthi.Location = new System.Drawing.Point(4, 54);
            this.lsvNoidungthi.Margin = new System.Windows.Forms.Padding(4);
            this.lsvNoidungthi.Name = "lsvNoidungthi";
            this.lsvNoidungthi.Size = new System.Drawing.Size(1066, 294);
            this.lsvNoidungthi.TabIndex = 0;
            this.lsvNoidungthi.UseCompatibleStateImageBehavior = false;
            this.lsvNoidungthi.View = System.Windows.Forms.View.Details;
            this.lsvNoidungthi.SelectedIndexChanged += new System.EventHandler(this.lsvNoidungthi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nội dung thi";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nội dung thi";
            this.columnHeader2.Width = 215;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mô tả";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày bắt đầu";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày kết thúc";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa điểm";
            this.columnHeader6.Width = 227;
            // 
            // txtNDT_search
            // 
            this.txtNDT_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNDT_search.Location = new System.Drawing.Point(143, 20);
            this.txtNDT_search.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDT_search.Name = "txtNDT_search";
            this.txtNDT_search.Size = new System.Drawing.Size(250, 22);
            this.txtNDT_search.TabIndex = 0;
            this.txtNDT_search.TextChanged += new System.EventHandler(this.txtNDT_search_TextChanged);
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
            // FrmQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmQLND";
            this.Tag = "Quản lý nội dung thi";
            this.Text = "Quản lý nội dung thi";
            this.Load += new System.EventHandler(this.FrmQLND_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaNDThi;
        private System.Windows.Forms.Label txtKH_ma;
        private System.Windows.Forms.DateTimePicker dateNgayketthuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnNDT_Huy;
        private FontAwesome.Sharp.IconButton btnNDT_Xoa;
        private FontAwesome.Sharp.IconButton btnNDT_Sua;
        private FontAwesome.Sharp.IconButton btnNDT_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNDThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgaybatdau;
        private System.Windows.Forms.TextBox txtDiadiem;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNDT_timkiem;
        private System.Windows.Forms.ListView lsvNoidungthi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtNDT_search;
        private System.Windows.Forms.Label label1;
    }
}