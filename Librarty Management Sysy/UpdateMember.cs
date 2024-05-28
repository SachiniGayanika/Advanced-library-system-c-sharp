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
using System.Text.RegularExpressions;

namespace Librarty_Management_Sysy
{
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBooks adb = new AddBooks();
            adb.Show();
        }

        private void btn_issueBook_Click(object sender, EventArgs e)
        {
            this.Close();
            IssueBooks isb = new IssueBooks();
            isb.Show();
        }

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnBooks rtb = new ReturnBooks();
            rtb.Show();
        }

        private void btn_meembers_Click(object sender, EventArgs e)
        {
            this.Close();
            Members m = new Members();
            m.Show();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            this.Close();
            books b = new books();
            b.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void btn_updatesearch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Create a command
            string sql = "SELECT*FROM members WHERE memberID=@id";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txt_updateid.Text);

            //Access data
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //Bind Data with controls

                this.txt_updateid.Text = dr.GetValue(0).ToString();
                this.txt_nic.Text = dr.GetValue(1).ToString();
                this.txt_name.Text = dr.GetValue(2).ToString();
                this.txt_email.Text = dr.GetValue(3).ToString();
                this.txt_telephone.Text = dr.GetValue(4).ToString();
                this.txt_dob.Text = dr.GetValue(5).ToString();
                this.cmb_gender.Text = dr.GetValue(6).ToString();
                this.txt_address.Text = dr.GetValue(7).ToString();


            }
            else
            {
                MessageBox.Show("No records found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Disconnected from server
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //
            string sql = "DELETE FROM  members  WHERE memberID=@id";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txt_updateid.Text);

            //Excute Query
            string mret = MessageBox.Show("Are you sure Delete this Record?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (mret == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of record Deleted." + ret, "Information",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //Disconnected
            con.Close();

            txt_updateid.Clear();
            txt_nic.Clear();
            txt_name.Clear();
            txt_email.Clear();
            txt_telephone.Clear();
            txt_dob.Clear();
            cmb_gender.ResetText();
            txt_address.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String memberID = txt_updateid.Text;
            String NIC = txt_nic.Text;
            String Name = txt_name.Text;
            String email = txt_email.Text;
            String telephone = txt_telephone.Text;
            String dob = txt_dob.Text;
            String gender = cmb_gender.Text;
            String address = txt_address.Text;

            String username = txt_username.Text;
            String password = txt_password.Text;

            if (!Regex.IsMatch(NIC, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                lbl_invalidNIC.Visible = true;
            }
            else if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                lbl_invalidEmail.Visible = true;
            }
            else if (!Regex.IsMatch(telephone, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                lbl_invalidTelephone.Visible = true;
            }
            /*else if (!Regex.IsMatch(dob, @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$"))
            {
                lbl_invalidTelephone.Visible = true;
            }*/
            else if (password.Length > 10)
            {
                lbl_invalidPass.Visible = true;
            }
            else
            {
                // Create a connection
                string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //
                string sql = "UPDATE members SET nicNumber=@nic,memberName=@name,emailAddress=@email,telephoneNumber=@tele,dob=@dob,gender=@gender,mAddress=@add WHERE nicNumber=@nic";
                SqlCommand com = new SqlCommand(sql, con);
                
                com.Parameters.AddWithValue("@nic", this.txt_nic.Text);
                com.Parameters.AddWithValue("@name", this.txt_name.Text);
                com.Parameters.AddWithValue("@email", this.txt_email.Text);
                com.Parameters.AddWithValue("@tele", this.txt_telephone.Text);
                com.Parameters.AddWithValue("@dob", this.txt_dob.Text);
                com.Parameters.AddWithValue("@gender", this.cmb_gender.Text);
                com.Parameters.AddWithValue("@add", this.txt_address.Text);

                com.ExecuteNonQuery();

                Sucess suc = new Sucess();
                suc.ShowDialog();

                

                con.Close();

               
               
            }
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            lbl_invalidNIC.Visible = false;
            lbl_invalidPass.Visible = false;
            lbl_invalidEmail.Visible = false;
            lbl_invalidTelephone.Visible = false;
           
        }
    }
}
