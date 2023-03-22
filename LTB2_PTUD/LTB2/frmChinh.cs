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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmLinkLabel_Click(object sender, EventArgs e)
        {
            var frm = new frmLinklabel();
            frm.ShowDialog();
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmButton();
            frm.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmComboBox();
            frm.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmListBox();
            frm.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRadioButton();
            frm.ShowDialog();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCheckListBox();
            frm.ShowDialog();
        }
    }
}
