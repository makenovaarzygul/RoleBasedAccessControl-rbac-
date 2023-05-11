using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class frm_login : Form

    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public frm_login()
        {
            InitializeComponent();
        }

        string log;
        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username='"+txt_UserName.Text+"'and Password='"+txt_Password.Text+"'",con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ulog.type = "A";
                }
                else if (dr[3].ToString() == "User")
                {
                    ulog.type = "U";
                }
                this.Hide();
                log = "Добро пожаловать:" + txt_UserName.Text;
                frm_Home fh = new frm_Home(log);
                fh.Show();

            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте ваш пароль или имя пользователя", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
