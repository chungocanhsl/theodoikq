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

namespace WindowsFormsApp1.Forms
{
    public partial class FrmQLND : Form
    {
        public FrmQLND()
        {
            InitializeComponent();
        }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();

        private void FrmQLND_Load(object sender, EventArgs e)
        {
            load_noidungthi();
        }

        void load_noidungthi()
        {
            lsvNoidungthi.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNoidungthi", conn)) 
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaNDThi"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenNDThi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Mota"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["Ngaybatdau"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["Ngayketthuc"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Diadiem"] + ""));
                            lsvNoidungthi.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btnNDT_Them_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "them_ndthi";
                        cmd.Parameters.AddWithValue("@MaNDThi ", txtMaNDThi.Text);
                        cmd.Parameters.AddWithValue("@TenNDThi ", txtTenNDThi.Text);
                        cmd.Parameters.AddWithValue("@Mota ", txtMota.Text);
                        cmd.Parameters.AddWithValue("@Ngaybatdau ", Convert.ToDateTime(dateNgaybatdau.Text));
                        cmd.Parameters.AddWithValue("@Ngayketthuc ", Convert.ToDateTime(dateNgayketthuc.Text));
                        cmd.Parameters.AddWithValue("@Diadiem ", txtDiadiem.Text);
               
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm nội dung thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_noidungthi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvNoidungthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvNoidungthi.SelectedItems)
            {
                txtMaNDThi.Text = item.SubItems[0].Text;
                txtTenNDThi.Text = item.SubItems[1].Text;
                txtMota.Text = item.SubItems[2].Text;
                dateNgaybatdau.Text = item.SubItems[3].Text;
                dateNgayketthuc.Text = item.SubItems[4].Text;
                txtDiadiem.Text = item.SubItems[5].Text;
               

            }
            txtMaNDThi.Enabled = false;

        }

        private void btnNDT_Sua_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "sua_ndthi";
                        cmd.Parameters.AddWithValue("@MaNDThi ", txtMaNDThi.Text);
                        cmd.Parameters.AddWithValue("@TenNDThi ", txtTenNDThi.Text);
                        cmd.Parameters.AddWithValue("@Mota ", txtMota.Text);
                        cmd.Parameters.AddWithValue("@Ngaybatdau ", Convert.ToDateTime(dateNgaybatdau.Text));
                        cmd.Parameters.AddWithValue("@Ngayketthuc ", Convert.ToDateTime(dateNgayketthuc.Text));
                        cmd.Parameters.AddWithValue("@Diadiem ", txtDiadiem.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_noidungthi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông tin nội dung thi không thành công! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNDT_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoa_ndthi";
                        cmd.Parameters.AddWithValue("@MaNDThi", txtMaNDThi.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa nội dung thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_noidungthi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNDT_Huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                txtMaNDThi.Text = "";
                txtMaNDThi.Enabled = true;
            }
        }

        private void btnNDT_timkiem_Click(object sender, EventArgs e)
        {
            lsvNoidungthi.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_ndthi";
                    cmd.Parameters.AddWithValue("@Key ", txtNDT_search.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaNDThi"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenNDThi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Mota"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["Ngaybatdau"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["Ngayketthuc"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Diadiem"] + ""));
                            lsvNoidungthi.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void txtNDT_search_TextChanged(object sender, EventArgs e)
        {
            if (txtNDT_search.Text != "")
            {
                btnNDT_timkiem.Enabled = true;
            }
            else
            {
                load_noidungthi();
                btnNDT_timkiem.Enabled = false;
            }
        }
    }
}
