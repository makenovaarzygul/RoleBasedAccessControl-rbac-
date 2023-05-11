using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Home : Form
    {
        public frm_Home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add_User_Admin fau = new frm_Add_User_Admin();
            fau.ShowDialog();
;        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if (ulog.type == "A")
            {
                btn_Add.Visible = true; 
                btn_Attendance.Visible = true;
                btn_Payment.Visible = true;
                btn_Report.Visible = true;
                btn_Settings.Visible = true;
                btn_Student.Visible = true;
            }
            else if(ulog.type == "U")
            {
                btn_Add.Visible = false;
                btn_Attendance.Visible = true;
                btn_Payment.Visible = false;
                btn_Report.Visible = true;
                btn_Settings.Visible = false;
                btn_Student.Visible = true;
            }
        }
    }
}
