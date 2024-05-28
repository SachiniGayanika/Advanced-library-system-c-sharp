using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarty_Management_Sysy
{
    public partial class viewBooks : Form
    {
        public viewBooks()
        {
            InitializeComponent();
        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet11.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter4.Fill(this.libraryManagementDataSet11.reservations);
            // TODO: This line of code loads data into the 'libraryManagementDataSet10.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter3.Fill(this.libraryManagementDataSet10.reservations);
            // TODO: This line of code loads data into the 'libraryManagementDataSet9.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter2.Fill(this.libraryManagementDataSet9.reservations);
            // TODO: This line of code loads data into the 'libraryManagementDataSet8.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter1.Fill(this.libraryManagementDataSet8.reservations);
            // TODO: This line of code loads data into the 'libraryManagementDataSet7.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.libraryManagementDataSet7.reservations);
            // TODO: This line of code loads data into the 'libraryManagementDataSet4.returnBooks' table. You can move, or remove it, as needed.
            this.returnBooksTableAdapter.Fill(this.libraryManagementDataSet4.returnBooks);
            // TODO: This line of code loads data into the 'libraryManagementDataSet3.issuedBooks' table. You can move, or remove it, as needed.
            this.issuedBooksTableAdapter.Fill(this.libraryManagementDataSet3.issuedBooks);
            // TODO: This line of code loads data into the 'libraryManagementDataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryManagementDataSet1.book);

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome w = new welcome();
            w.Show();
        }
    }
}
