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
    public partial class FrmQLDT : Form
    {
        public FrmQLDT()
        {
            InitializeComponent();
        }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();

        private void FrmQLDT_Load(object sender, EventArgs e)
        {
            load_doithi();
            loadMaGV();
            loadMaNDThi();


        }

        /*private DataTable Doithi()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblDoithi", conn)) //order by id asc
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tblDoithi");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }*/

        /*private void hienMaGV()
        {
            DataTable t = Doithi();
            DataView v = new DataView(t);
            v.Sort = "MaGV";
            cbMaGV.DataSource = v;
            cbMaGV.DisplayMember = "MaGV";
            cbMaGV.ValueMember = "MaGV";
        }*/



        /*private void hienMaNDT()
        {
            DataTable t = Doithi();
            DataView v = new DataView(t);
            v.Sort = "MaNDThi";
            cbMaNDT.DataSource = v;
            cbMaNDT.DisplayMember = "MaNDThi";
            cbMaNDT.ValueMember = "MaNDThi";
        }*/
        void loadMaGV()

        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblGiangVien", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    cbMaGV.DisplayMember = "MaGV";
                    cbMaGV.DataSource = dt;
                    //cbMaGV.ValueMember = "MaGV";

                }
            }

        }

      void loadMaNDThi()

        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNoidungthi", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    cbMaNDT.DisplayMember = "MaNDThi";
                    cbMaNDT.DataSource = dt;
                    //cbMaGV.ValueMember = "MaNDThi";

                }
            }

        }



        void load_doithi()
        {
            lsvDoithi.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_hiendoithi", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaDoi"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenDoi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Ketqua"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Nam"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["MaGV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenGV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["MaNDThi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenNDThi"] + ""));
                            lsvDoithi.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
            txtKetqua.Enabled = false;
        }

        private void lsvDoithi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvDoithi.SelectedItems)
            {
                txtMadoi.Text = item.SubItems[0].Text;
                txtTendoi.Text = item.SubItems[1].Text;
                txtKetqua.Text = item.SubItems[2].Text;
                dateNam.Text = item.SubItems[3].Text;
                cbMaGV.Text = item.SubItems[4].Text;
                cbMaNDT.Text = item.SubItems[5].Text;

            }
            txtKetqua.Enabled = true;
        }


        private void btnDT_Them_Click(object sender, EventArgs e)
        {
            //Kiểm tra textbox không được rỗng
           /*foreach (Control c in groupBox2.Controls)
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
            }*/
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "them_doithi";
                        cmd.Parameters.AddWithValue("@MaDoi ", txtMadoi.Text);
                        cmd.Parameters.AddWithValue("@TenDoi ", txtTendoi.Text);
                        cmd.Parameters.AddWithValue("@Ketqua ", txtKetqua.Text);
                        cmd.Parameters.AddWithValue("@Nam ", dateNam.Text);
                        cmd.Parameters.AddWithValue("@MaGV ", cbMaGV.Text);
                        cmd.Parameters.AddWithValue("@MaNDThi ", cbMaNDT.Text);


                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm đội thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_doithi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(cbMaNDT.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDT_Sua_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "sua_doithi";
                        cmd.Parameters.AddWithValue("@MaDoi ", txtMadoi.Text);
                        cmd.Parameters.AddWithValue("@TenDoi ", txtTendoi.Text);
                        cmd.Parameters.AddWithValue("@Ketqua ", txtKetqua.Text);
                        cmd.Parameters.AddWithValue("@Nam ", dateNam.Text);
                        cmd.Parameters.AddWithValue("@MaGV ", cbMaGV.Text);
                        cmd.Parameters.AddWithValue("@MaNDThi ", cbMaNDT.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_doithi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thông tin đội thi không thành công! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDT_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoa_doithi";
                        cmd.Parameters.AddWithValue("@MaDoi", txtMadoi.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa đội thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_doithi();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDT_Huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                txtMadoi.Text = "";
            }
        }

        private void btnDT_timkiem_Click(object sender, EventArgs e)
        {
            lsvDoithi.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_doithi";
                    cmd.Parameters.AddWithValue("@Key ", txtDT_search.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaDoi"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["TenDoi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Ketqua"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Nam"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["MaGV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["MaNDThi"] + ""));
                            lsvDoithi.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }
    }
    
}
