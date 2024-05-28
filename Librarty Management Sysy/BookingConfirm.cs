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
    public partial class BookingConfirm : Form
    {
        String dateC;
        public BookingConfirm(String date)
        {
            InitializeComponent();
            this.dateC = date;
            txt_date.Text = date;
        }

        private void BookingConfirm_Load(object sender, EventArgs e)
        {
            //txt_date.Text = date;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
