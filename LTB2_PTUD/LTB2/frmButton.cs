using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTB2
{
    public partial class frmButton : Form
    {
        public frmButton()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Set to no text.
            //txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string message = "Thành Công";
            string title = "Thông Báo";
            MessageBox.Show(message, title);
        }
    }
}
