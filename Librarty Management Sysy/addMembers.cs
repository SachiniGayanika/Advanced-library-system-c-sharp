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

using System.Text.RegularExpressions;

namespace Librarty_Management_Sysy
{
    public partial class addMembers : Form
    {
        public addMembers()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 10;
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
            Members mb = new Members();
            mb.Show();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string memberID = txt_memberid.Text;
            String NIC = txt_nic.Text;
            String Name = txt_name.Text;
            String email = txt_email.Text;
            String telephone = txt_telephone.Text;
            String dob = txt_dob.Text;
            String gender = cmb_gender.Text;
            String address = txt_address.Text;

            String username = txt_username.Text;
            String password = txt_password.Text;

            if(!Regex.IsMatch(NIC, @"^([0-9]{9}[x|X|v|V]|[0-9]{12})$"))
            {
                ibl_invalidNIC.Visible = true;
            }else if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                ibl_invalidEmail.Visible = true;
            }else if (!Regex.IsMatch(telephone, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                lbl_invalidTelephone.Visible = true;
            }/*else if (!Regex.IsMatch(dob, @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\\d\\d$"))
            {
                lbl_invalidTelephone.Visible = true;
            }*/else if (password.Length>10)
            {
                lbl_invalidPass.Visible = true;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True");
                con.Open();
                SqlCommand cmdOne = new SqlCommand("insert into members (nicNumber, memberName, emailAddress, telephoneNumber, dob, gender, mAddress) values ('" + NIC + "','" + Name + "','" + email + "','" + telephone + "','" + dob + "','" + gender + "','" + address + "')", con);
                int i = cmdOne.ExecuteNonQuery();
                cmdOne.Dispose();

                SqlCommand cmdTwo = new SqlCommand("insert into users values ('" + username + "','" + password + "','ma')", con);
                int ii = cmdTwo.ExecuteNonQuery();

                if (i == 1 && ii == 1)
                {
                    //Sending Email [Tutorial link : https://randomnerdtutorials.com/esp32-send-email-smtp-server-arduino-ide/]
                    MailAddress to = new MailAddress(txt_email.Text);
                    MailAddress from = new MailAddress("asnglibrary@gmail.com");

                    MailMessage mail = new MailMessage(from, to);
                    mail.Subject = "Registration Sucess to ASNG Library";
                    mail.Body = "We are delighted to inform you that you have been successfully registered to the ASNG Library Management System. Your credentials have been verified, and you can now begin using the system to reserve books from our extensive collection.\nBelow, you will find your details:\n\nName : " + txt_name.Text + "\nMember ID : " + txt_memberid.Text + "\nEmail Address : " + txt_email.Text + "\nTelephone Number : " + txt_telephone.Text + "\n\nCREDENTIALS\nUsername : " + txt_username.Text + "\nPassword : " + txt_password.Text + "\n\nIf you encounter any issues or have questions regarding the ASNG Library Management System, please feel free to contact our friendly staff at [Library Contact Information]. They will be more than happy to assist you.\nWe hope that the ASNG Library Management System enriches your reading experience and provides you with easy access to a vast collection of books. Enjoy exploring our library and make the most of the resources available to you.";

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
                        smtp.Send(mail);
                    }
                    catch (SmtpException ex)
                    {
                        Console.WriteLine(ex.ToString());

                        MessageBox.Show(ex.ToString(), "Email Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txt_memberid.Clear();
                    txt_address.Clear();
                    txt_dob.Clear();
                    txt_email.Clear();
                    txt_name.Clear();
                    txt_nic.Clear();
                    txt_password.Clear();
                    txt_telephone.Clear();
                    txt_username.Clear();

                    Sucess suc = new Sucess();
                    suc.ShowDialog();
                }
                else
                {
                    error404F err = new error404F();
                    err.ShowDialog();
                }

                cmdTwo.Dispose();

                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_memberid.Clear();
            txt_address.Clear();
            txt_dob.Clear();
            txt_email.Clear();
            txt_name.Clear();
            txt_nic.Clear();
            txt_password.Clear();
            txt_telephone.Clear();
            txt_username.Clear();

            lbl_invalidTelephone.Visible = false;
            lbl_invalidPass.Visible = false;
            ibl_invalidNIC.Visible = false;
            ibl_invalidEmail.Visible = false;
            lbl_invalidTelephone.Visible = false;
        }

        private void addMembers_Load(object sender, EventArgs e)
        {
            lbl_invalidTelephone.Visible = false;
            lbl_invalidPass.Visible = false;
            ibl_invalidNIC.Visible = false;
            ibl_invalidEmail.Visible = false;
            lbl_invalidTelephone.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_memberid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
