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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();

        private void FrmTest_Load(object sender, EventArgs e)
        {
            loadMaSV();
        }

        void loadMaSV()

        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSinhVien", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    cbSV.DisplayMember = "TenSV";
                    cbSV.DataSource = dt;
                    cbSV.ValueMember = "MaSV";

                }
            }

        }

        private void cbSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbSV.SelectedValue.ToString());
        }
    }
}
