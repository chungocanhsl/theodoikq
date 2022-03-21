using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ChildForm
{
    public partial class FrmQLSV : Form
    {
        public FrmQLSV()
        {
            InitializeComponent();
        }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();


        private void FrmQLSV_Load(object sender, EventArgs e)
        {
            load_sinhvien();
        }

        void load_sinhvien()
        {
            lsvSinhVien.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSinhVien", conn)) //order by id asc
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaSV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenSV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["GioiTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["NgaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Lop"] + ""));
                            lsvSinhVien.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }
        void check_MaSV()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSinhVien where MaSV = '"+txtMaSV.Text+"'", conn)) //order by id asc
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            MessageBox.Show("Mã sinh viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btnSV_Them_Click(object sender, EventArgs e)
        {
            check_MaSV();
            //Kiểm tra textbox không được rỗng
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "them_sv";
                        cmd.Parameters.AddWithValue("@MaSV ", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@TenSV ", txtTenSV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh ", cbSV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sdt ", txtSDT_SV.Text);
                        cmd.Parameters.AddWithValue("NgaySinh ", Convert.ToDateTime(ns_SV.Text));
                        cmd.Parameters.AddWithValue("@Email ", txtEmail_SV.Text);
                        cmd.Parameters.AddWithValue("@lop ", txtSV_lop.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_sinhvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSV_Sua_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sua_sv";
                        cmd.Parameters.AddWithValue("@MaSV ", txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@TenSV ", txtTenSV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh ", cbSV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sdt ", txtSDT_SV.Text);
                        cmd.Parameters.AddWithValue("NgaySinh ", Convert.ToDateTime(ns_SV.Text));
                        cmd.Parameters.AddWithValue("@Email ", txtEmail_SV.Text);
                        cmd.Parameters.AddWithValue("@lop ", txtSV_lop.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_sinhvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông tin sinh viên không thành công! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvSinhVien.SelectedItems)
            {
                txtMaSV.Text = item.SubItems[0].Text;
                txtTenSV.Text = item.SubItems[1].Text;
                cbSV.Text = item.SubItems[2].Text;
                txtSDT_SV.Text = item.SubItems[3].Text;
                ns_SV.Text = item.SubItems[4].Text;
                txtEmail_SV.Text = item.SubItems[5].Text;
                txtSV_lop.Text = item.SubItems[6].Text;

            }
        }

        private void btnSV_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoa_sv";
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_sinhvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSV_Huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                txtMaSV.Text = "";
                ns_SV.Text = "";

            }
        }

        private void btnSV_timkiem_Click(object sender, EventArgs e)
        {
            lsvSinhVien.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_sv";
                    cmd.Parameters.AddWithValue("@Key ", txtSV_search.Text);
                  
                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaSV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenSV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["GioiTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["NgaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["lop"] + ""));
                            lsvSinhVien.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void txtSV_search_TextChanged(object sender, EventArgs e)
        {
            if (txtSV_search.Text != "")
            {
                btnSV_timkiem.Enabled = true;
            }
            else
            {
                load_sinhvien();
                btnSV_timkiem.Enabled = false;
            }
        }
    }
    
}
