using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ChildForm;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());



            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin);
            if (frmLogin.IsLogin == true)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
