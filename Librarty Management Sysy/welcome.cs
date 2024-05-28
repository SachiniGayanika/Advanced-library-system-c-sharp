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

namespace Librarty_Management_Sysy
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 10;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_invalid_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Load(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from users where username = '" + username + "' and password = '" + password + "' and accessLable = 'ma'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Reserve_Book rs = new Reserve_Book();
                rs.Show();
            }
            else
            {
                SqlDataAdapter daUL = new SqlDataAdapter("select count(*) from users where username = '" + username + "' and password = '" + password + "' and accessLable = 'ad'", con);
                DataTable dtUL = new DataTable();
                daUL.Fill(dtUL);

                if (dtUL.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    AddBooks adb = new AddBooks();
                    adb.Show();
                }
                else
                {
                    lbl_invalid.Show();
                }
            }
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
            lbl_invalid.Visible = false;
        }
    }
}
