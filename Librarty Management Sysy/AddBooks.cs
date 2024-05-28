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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

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

        private void btn_members_Click(object sender, EventArgs e)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_author.Clear();
            txt_bookName.Clear();
            txt_description.Clear();
            txt_isbn.Clear();
            txt_publication.Clear();
            txt_qty.Clear();
            lbl_invlidInput.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(txt_qty.Text);
            

            if (qty < 1)
            {
                lbl_invlidInput.Visible = true;
            }
            else
            {
                string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

             
                string sql = "INSERT INTO  book(isbn,boolkName,author,category,publication,quantity,description)VALUES(@isbn,@bname,@author,@cat,@publi,@quan,@descri)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@isbn", this.txt_isbn.Text);
                com.Parameters.AddWithValue("@bname", this.txt_bookName.Text);
                com.Parameters.AddWithValue("@author", this.txt_author.Text);
                com.Parameters.AddWithValue("@cat", this.cmbx_cat.Text);
                com.Parameters.AddWithValue("@publi", this.txt_publication.Text);
                com.Parameters.AddWithValue("@quan", this.txt_qty.Text);
                com.Parameters.AddWithValue("@descri", this.txt_description.Text);

                int i = com.ExecuteNonQuery();
                com.Dispose();

                con.Close();

                if (i == 1)
                {
                    txt_author.Clear();
                    txt_bookName.Clear();
                    txt_description.Clear();
                    txt_isbn.Clear();
                    txt_publication.Clear();
                    txt_qty.Clear();
                    lbl_invlidInput.Visible = false;

                    Sucess suc = new Sucess();
                    suc.ShowDialog();
                }
                else
                {
                    error404F err = new error404F();
                    err.ShowDialog();
                }

                con.Close();
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            lbl_invlidInput.Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Create a command
            string sql = "SELECT*FROM book WHERE isbn=@id";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txt_isbn.Text);

            //Access data
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //Bind Data with controls

                this.txt_isbn.Text = dr.GetValue(0).ToString();
                this.txt_bookName.Text = dr.GetValue(1).ToString();
                this.txt_author.Text = dr.GetValue(2).ToString();
                this.cmbx_cat.Text = dr.GetValue(3).ToString();
                this.txt_publication.Text = dr.GetValue(4).ToString();
                this.txt_qty.Text = dr.GetValue(5).ToString();
                this.txt_description.Text = dr.GetValue(6).ToString();

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
            string sql = "DELETE FROM  book  WHERE isbn=@no";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@no", this.txt_isbn.Text);

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


            txt_isbn.Clear();
            txt_bookName.Clear();
            txt_author.Clear();
            cmbx_cat.ResetText();
            txt_publication.Clear();
            txt_qty.Clear();
            
            txt_description.Clear();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
