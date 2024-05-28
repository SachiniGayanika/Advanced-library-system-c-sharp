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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        private void btn_addBooks_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBooks ad = new AddBooks();
            ad.Show();
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
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }

        private void btn_members_Click(object sender, EventArgs e)
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

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBooks adb = new AddBooks();
            adb.Show();
        }

        private void btn_updateB_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateBook upb = new UpdateBook();
            upb.Show();
        }

        private void btn_viewB_Click(object sender, EventArgs e)
        {
            this.Close();
            viewBooks vb = new viewBooks();
            vb.Show();
        }

        private void btn_viewallbook_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewAllBook vab = new ViewAllBook();
            vab.Show();
        }
    }
}
