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
using System.Net;
using System.Net.Mail;

namespace Librarty_Management_Sysy
{
    public partial class IssueBooks : Form
    {
        int qty = 0;
        public IssueBooks()
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
            addMembers m = new addMembers();
            m.Show();
        }

        private void btn_book_Click(object sender, EventArgs e)
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

        private void btn_issue_Click(object sender, EventArgs e)
        {
            qty = Int32.Parse(lbl_qty.Text);
            qty = qty - 1;
            lbl_qty.Text = qty.ToString();

            String isbn = txt_isbn.Text;
            String bName = txt_isbn.Text;
            String mID = txt_mID.Text;
            String mName = txt_mName.Text;
            String iDate = txt_iDate.Text;
            String dDate = txt_dDate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmdOne = new SqlCommand("insert into issuedBooks (bookISBN,bookName,memID,memName,issuedDate,dueDate) values ('" + isbn + "','" + bName + "','" + mID + "','" + mName + "','" + iDate + "','" + dDate + "')", con);
            int i = cmdOne.ExecuteNonQuery();
            cmdOne.Dispose();

            if (i == 1)
            {
                //Sending Email [Tutorial link : https://randomnerdtutorials.com/esp32-send-email-smtp-server-arduino-ide/]
                MailAddress to = new MailAddress(txt_email.Text);
                MailAddress from = new MailAddress("asnglibrary@gmail.com");

                MailMessage email = new MailMessage(from, to);
                email.Subject = "Issuence of Book | " + txt_bName.Text + ".";
                email.Body = "BOOK DETAILS\n\nBook Name : " + txt_bName.Text + "\nISBN : " + txt_isbn.Text + "\n\nMEMBER DETAILS\n\nMember ID : " + txt_mID.Text + "\nMember Name : " + txt_mName.Text + "\nDate Issued : " + txt_iDate.Text + "\n\n\nReturning the book promptly not only helps maintain a smooth circulation system but also prevents any overdue charges or penalties that may be incurred if the book is not returned on time.\n\nTo return the book, please visit the ASNG Library during its operating hours and hand it over to the circulation desk.Our library staff will process the return and update your account accordingly. If you require any assistance or have any questions, please don't hesitate to reach out to our friendly library staff.\n\nIn case you are unable to return the book by the due date due to unforeseen circumstances, we kindly request that you contact us as soon as possible.We can work together to find a suitable solution, such as a renewal or extension of the borrowing period, to accommodate your needs..";

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("asnglibrary@gmail.com", "bvltjabglrhwqagh");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;

                try
                {
                    /* Send method called below is what will send off our email 
                     * unless an exception is thrown.
                     */
                    smtp.Send(email);
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine(ex.ToString());

                    MessageBox.Show(ex.ToString(), "Email Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_bName.Clear();
                txt_dDate.Clear();
                txt_iDate.Clear();
                txt_isbn.Clear();
                txt_mID.Clear();
                txt_mName.Clear();

                Sucess suc = new Sucess();
                suc.ShowDialog();

                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");

                con1.Open();
                string sql1 = "UPDATE book SET quantity=@qty where boolkName='lili'";
                SqlCommand com1 = new SqlCommand(sql1, con1);
                com1.Parameters.AddWithValue("@id", this.txt_isbn.Text);
                com1.Parameters.AddWithValue("@qty", this.lbl_qty.Text);

                //Excute Query
                com1.ExecuteNonQuery();

                con1.Close();
            }
            else
            {
                error404F err = new error404F();
                err.ShowDialog();
            }

            con.Close();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bName.Clear();
            txt_dDate.Clear();
            txt_iDate.Clear();
            txt_isbn.Clear();
            txt_mID.Clear();
            txt_mName.Clear();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

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
                this.txt_bName.Text = dr.GetValue(1).ToString();
                
                this.lbl_qty.Text = dr.GetValue(5).ToString();
                

            }
            else
            {
                MessageBox.Show("No records found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Disconnected from server
            con.Close();
        }
    }
}
