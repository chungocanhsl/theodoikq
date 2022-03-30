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
    public partial class FrmQLGV : Form
    {
        public FrmQLGV()
        {
            InitializeComponent();
        }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();

        private void FrmQLGV_Load(object sender, EventArgs e)
        {
            load_giangvien();
        }

        void load_giangvien()
        {
            lsvGiangVien.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblGiangVien", conn)) //order by id asc
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaGV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenGV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["GioiTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["NgaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Username"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Password"] + ""));
                            lsvGiangVien.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btnGV_Them_Click(object sender, EventArgs e)
        {
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
                        cmd.CommandText = "them_gv";
                        cmd.Parameters.AddWithValue("@MaGV ", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@TenGV ", txtTenGV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh ", cbGV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sdt ", txtSDT_GV.Text);
                        cmd.Parameters.AddWithValue("NgaySinh ", Convert.ToDateTime(ns_GV.Text));
                        cmd.Parameters.AddWithValue("@Email ", txtGV_email.Text);
                        cmd.Parameters.AddWithValue("@Username ", txtGV_username.Text);
                        cmd.Parameters.AddWithValue("@Password ", txtGV_pass.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_giangvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGV_Sua_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "sua_gv";
                        cmd.Parameters.AddWithValue("@MaGV ", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@TenGV ", txtTenGV.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh ", cbGV.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sdt ", txtSDT_GV.Text);
                        cmd.Parameters.AddWithValue("NgaySinh ", Convert.ToDateTime(ns_GV.Text));
                        cmd.Parameters.AddWithValue("@Email ", txtGV_email.Text);
                        cmd.Parameters.AddWithValue("@Username ", txtGV_username.Text);
                        cmd.Parameters.AddWithValue("@Password ", txtGV_pass.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_giangvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông tin giảng viên không thành công! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvGiangVien.SelectedItems)
            {
                txtMaGV.Text = item.SubItems[0].Text;
                txtTenGV.Text = item.SubItems[1].Text;
                cbGV.Text = item.SubItems[2].Text;
                txtSDT_GV.Text = item.SubItems[3].Text;
                ns_GV.Text = item.SubItems[4].Text;
                txtGV_email.Text = item.SubItems[5].Text;
                txtGV_username.Text = item.SubItems[6].Text;
                txtGV_pass.Text = item.SubItems[7].Text;
                
            }
        }

        private void btnGV_Xoa_Click(object sender, EventArgs e)
        {
           try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoa_gv";
                        cmd.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_giangvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGV_Huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                txtMaGV.Text = "";
                ns_GV.Text = "";
            }
        }

        private void btnGV_timkiem_Click(object sender, EventArgs e)
        {
            lsvGiangVien.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_gv";
                    cmd.Parameters.AddWithValue("@Key ", txtGV_search.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaGV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenGV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["GioiTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["NgaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Username"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Password"] + ""));
                            lsvGiangVien.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void txtGV_search_TextChanged(object sender, EventArgs e)
        {
            if (txtGV_search.Text != "")
            {
                btnGV_timkiem.Enabled = true;
            }
            else
            {
                load_giangvien();
                btnGV_timkiem.Enabled = false;
            }
        }
    }
}
