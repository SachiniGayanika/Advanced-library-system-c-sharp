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
    public partial class ReturnBooks : Form
    {
        int qty = 0;
        public ReturnBooks()
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mName.Clear();
            txt_memID.Clear();
            txt_isseDate.Clear();
            txt_ISBN.Clear();
            txt_bookName.Clear();
            txt_dueDate.Clear();
            txt_returnDate.Clear();
            lbl_fine.Text = "There is no fine records available";
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            qty = Int32.Parse(lbl_qty.Text);
            qty = qty + 1;
            lbl_qty.Text = qty.ToString();

            String mName = txt_mName.Text;
            String mID = txt_memID.Text;
            String bName = txt_bookName.Text;
            String isbn = txt_ISBN.Text;
            String issDate = txt_isseDate.Text;
            String dueDate = txt_dueDate.Text;
            String retDate = txt_returnDate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmdOne = new SqlCommand("insert into returnBooks (bookISBN,bookName,memID,memName,issuedDate,dueDate,returnDate) values ('" + isbn + "','" + bName + "','" + mID + "','" + mName + "','" + issDate + "','" + dueDate + "','"+retDate+"')", con);
            int i = cmdOne.ExecuteNonQuery();
            cmdOne.Dispose();

            if (i == 1)
            {
                //Sending Email [Tutorial link : https://randomnerdtutorials.com/esp32-send-email-smtp-server-arduino-ide/]
                MailAddress to = new MailAddress(txt_email.Text);
                MailAddress from = new MailAddress("asnglibrary@gmail.com");

                MailMessage email = new MailMessage(from, to);
                email.Subject = "Return of Book | " + txt_bookName.Text + ".";
                email.Body = "BOOK DETAILS\n\nBook Name : " + txt_bookName.Text + "\nISBN : " + txt_ISBN.Text + "\n\nMEMBER DETAILS\n\nMember ID : " + txt_memID.Text + "\nMember Name : " + txt_mName.Text + "\nDate Issued : " + txt_isseDate.Text + "\nDate Returned : " + txt_returnDate.Text + "\nDue Date : " + txt_dueDate.Text + "\n\n\nBy returning the book on or before the due date, you have helped ensure that other library members have the opportunity to borrow and enjoy it as well. Your adherence to the library's policies is greatly appreciated.\n\nIf you have any further inquiries or require assistance with any other library services, please do not hesitate to reach out to our friendly library staff.We are always here to assist you.\n\nOnce again, thank you for returning the book on time.We hope that you found it informative and enjoyable.Your responsible borrowing contributes to the overall functioning of the library and enables us to continue providing a wide range of resources to our valued patrons.\n\nWe look forward to serving you again in the future.";

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

                txt_mName.Clear();
                txt_memID.Clear();
                txt_isseDate.Clear();
                txt_ISBN.Clear();
                txt_bookName.Clear();
                txt_dueDate.Clear();
                txt_returnDate.Clear();
                lbl_fine.Text = "There is no fine records available";

                Sucess suc = new Sucess();
                suc.ShowDialog();

                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");

                con1.Open();
                string sql1 = "UPDATE book SET quantity=@qty where boolkName='lili'";
                SqlCommand com1 = new SqlCommand(sql1, con1);
                com1.Parameters.AddWithValue("@id", this.txt_ISBN.Text);
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

        private void btn_search_Click(object sender, EventArgs e)
        {


            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // Create a command
            string sql = "SELECT*FROM book WHERE isbn=@id";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txt_ISBN.Text);

            //Access data
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //Bind Data with controls

                this.txt_ISBN.Text = dr.GetValue(0).ToString();
                this.txt_bookName.Text = dr.GetValue(1).ToString();
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
