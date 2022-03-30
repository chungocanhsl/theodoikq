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
using WindowsFormsApp1.Report;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmTKBC : Form
    {
        public FrmTKBC()
        {
            InitializeComponent();
        }

        public static String conStr = ConfigurationManager.ConnectionStrings["OlympicConnString"].ConnectionString.ToString();


        private void FrmTKBC_Load(object sender, EventArgs e)
        {
            load_SV();
            load_NDT();
            load_Nam();
        }

        void load_SV()
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

        void load_NDT()
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
                    cbNDT.DisplayMember = "TenNDThi";
                    cbNDT.DataSource = dt;
                    cbNDT.ValueMember = "MaNDThi";

                }
            }
        }

        void load_Nam()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblDoithi", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    //cbNam.DisplayMember = "Nam";
                    cbNam.DataSource = dt;
                    cbNam.ValueMember = "Nam";

                }
            }
        }

        private void btnTKSV_Click(object sender, EventArgs e)
        {
            CRSV cr = new CRSV();
            cr.RecordSelectionFormula = "{tblChitietDoi.MaSV} = '" + cbSV.SelectedValue.ToString() + "' ";
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }

        private void btnTKNDT_Click(object sender, EventArgs e)
        {
            CRNDT cr = new CRNDT();
            cr.RecordSelectionFormula = "{tblDoithi.MaNDThi} = '" + cbNDT.SelectedValue.ToString() + "' ";
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }

        private void btnTKNam_Click(object sender, EventArgs e)
        {
            CRNam cr = new CRNam();
            cr.RecordSelectionFormula = "{tblDoithi.Nam} = " + cbNam.SelectedValue.ToString() + " ";
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }

        private void cbSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
