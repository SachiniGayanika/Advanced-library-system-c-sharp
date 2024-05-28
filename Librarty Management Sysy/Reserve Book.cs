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
using System.Net;
using System.Net.Mail;

namespace Librarty_Management_Sysy
{
    public partial class Reserve_Book : Form
    {
        int qty = 0, id=0;
        String quantity;
        public Reserve_Book()
        {
            InitializeComponent();
        }

        //search button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            String txt = "%" + txt_search + "%";
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM book where boolkName like('" + txt + "') or isbn like('" + txt + "')", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;

            //txt_search.Clear();
            con.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_author.Clear();
            txt_bookName.Clear();
            txt_dateCollect.Clear();
            txt_isbn.Clear();
            txt_memberID.Clear();
            txt_memberName.Clear();

          
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.libraryManagementDataSet.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Reserve_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryManagementDataSet.book);
            
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            
            String ISBN = txt_isbn.Text;
            String bookName = txt_bookName.Text;
            String bookAuthor = txt_author.Text;
            String mID = txt_memberID.Text;
            String mName = txt_memberName.Text;
            String colDate = txt_dateCollect.Text;

          
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                con.Open();
                SqlCommand cmdOne = new SqlCommand("insert into reservations (isbn,bookName,bookAuthor,memberID,memberName,dateCollecting) values ('"+ISBN+"','"+bookName+"','"+bookAuthor+"','"+mID+"','"+mName+"','"+colDate+"')", con);
                int i = cmdOne.ExecuteNonQuery();
                cmdOne.Dispose();

                if (i == 1)
                {

                BookingConfirm bc = new BookingConfirm(this.txt_dateCollect.Text);
                bc.Show();

                qty = Int32.Parse(lbl_qty.Text);
                lbl_qty.Text = qty.ToString();

                con.Close();

                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                
                con1.Open();

                //
                string sql1 = "UPDATE book SET quantity=@qty where boolkName='lili'";
                SqlCommand com1 = new SqlCommand(sql1, con1);
                com1.Parameters.AddWithValue("@id",id);
                com1.Parameters.AddWithValue("@qty", this.lbl_qty.Text);

                //Excute Query
                com1.ExecuteNonQuery();

                con1.Close();

                //Sending Email [Tutorial link : https://randomnerdtutorials.com/esp32-send-email-smtp-server-arduino-ide/]
                MailAddress to = new MailAddress(txt_email.Text);
                MailAddress from = new MailAddress("asnglibrary@gmail.com");

                MailMessage email = new MailMessage(from, to);
                email.Subject = "Booking Confirmation | "+txt_bookName.Text+ ".";
                email.Body = "BOOK DETAILS\n\nBook Name : "+txt_bookName.Text+"\nISBN : "+txt_isbn.Text+"\n\nMEMBER DETAILS\n\nMember ID : "+txt_memberID.Text+"\nMember Name : "+txt_memberName.Text+"\nDate Collection : "+txt_dateCollect.Text+ "\n\n\nBooking Confirm, Pleace collet your book on mentioned date this booking will expire if you don't collect book after 3 days of collection date.";

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

                txt_author.Clear();
                txt_bookName.Clear();
                txt_dateCollect.Clear();
                txt_isbn.Clear();
                txt_memberID.Clear();
                txt_memberName.Clear();

            }
                
                else
                {
                    error404F err = new error404F();
                    err.ShowDialog(); 
                }

                con.Close();
            
        }

        private void txt_dateCollect_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT* FROM book WHERE boolkName=@name";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@name", this.txt_bookName.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                this.txt_isbn.Text = dr.GetValue(0).ToString();
               /* this.txt_reservebookname= dr.GetValue(1).ToString();*/
                this.txt_author.Text = dr.GetValue(2).ToString();
                this.lbl_qty.Text = dr.GetValue(5).ToString();
               
            }
            else
            {
                MessageBox.Show("No Records Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            //id = Int32.Parse(this.txt_isbn.Text);
            qty = Int32.Parse(lbl_qty.Text);
            qty = qty - 1;
            lbl_qty.Text = qty.ToString();
        }
    }
}
