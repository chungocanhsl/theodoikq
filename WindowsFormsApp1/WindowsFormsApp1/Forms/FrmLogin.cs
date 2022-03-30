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
    public partial class FrmLogin : Form
    {
        public bool IsLogin { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();

        public FrmLogin()
        {
            InitializeComponent();
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            IsLogin = false;
            /*var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey500, Primary.Grey300, Accent.Blue700, TextShade.WHITE);*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                    if (txtUsername.Text == string.Empty || txtPass.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
              

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblGiangVien where Username ='" + txtUsername.Text + "' and Password='" + txtPass.Text + "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read() == true)
                    {
                        //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                        IsLogin = true;
                        GlobalValue.FullName = dataReader["TenGV"].ToString();
                        GlobalValue.Username = txtUsername.Text;
                        //FullName = dataReader["TenGV"].ToString();
                        GlobalValue.Password = txtPassword.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công, hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    conn.Close();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
