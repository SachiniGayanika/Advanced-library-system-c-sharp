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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void btn_meembers_Click(object sender, EventArgs e)
        {
            this.Close();
            Members mem = new Members();
            mem.Show();
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

        private void btn_addMembers_Click(object sender, EventArgs e)
        {
            this.Close();
            addMembers adm = new addMembers();
            adm.Show();
        }

        private void btn_updateM_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateMember upm = new UpdateMember();
            upm.Show();
        }

        private void btn_viewM_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewMember vm = new ViewMember();
            vm.Show();
        }
    }
}
