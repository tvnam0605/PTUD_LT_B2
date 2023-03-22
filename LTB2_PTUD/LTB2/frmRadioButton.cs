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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {

        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
                this.btnButton.ForeColor = Color.Red;
            else
                this.btnButton.ForeColor = Color.Black;
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.btnFlat.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnFlat.FlatStyle = FlatStyle.Popup;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNam.Checked)
                MessageBox.Show("Giới tính của bạn là nam!" + rdNam.Text);
            
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdNu.Checked)
                MessageBox.Show("Giới tính của bạn là nữ!" + rdNu.Text);
        }
    }
}
