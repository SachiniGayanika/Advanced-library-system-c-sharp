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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btn_addBooks_Click(object sender, EventArgs e)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Create a connection
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //
            string sql = "UPDATE book SET boolkName=@name,author=@author ,category=@cate,publication=@publi,quantity=@qty,description=@des WHERE isbn=@isbn";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@isbn", this.txt_isbn.Text);
            com.Parameters.AddWithValue("@name", this.txt_bookName.Text);
            com.Parameters.AddWithValue("@author", this.txt_author.Text);
            com.Parameters.AddWithValue("@cate",this.cmbx_cat.Text);
            com.Parameters.AddWithValue("@publi", this.txt_publication.Text);
            com.Parameters.AddWithValue("@qty", this.txt_qty.Text);
            com.Parameters.AddWithValue("@des", this.txt_description.Text);

            //Excute Query
            com.ExecuteNonQuery();

            string mret = MessageBox.Show("Confirm Update", "Question",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (mret == "Yes")
            {
                Sucess suc = new Sucess();
                suc.ShowDialog();
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

        private void UpdateBook_Load(object sender, EventArgs e)
        {

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
            com.ExecuteNonQuery();
            //Excute Query
            string mret = MessageBox.Show("Are you sure Delete this Record?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (mret == "Yes")
            {
                Sucess suc = new Sucess();
                suc.ShowDialog();
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }
    }
}
