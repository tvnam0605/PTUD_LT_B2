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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhSach.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
                // lstDanhsach.Items.RemoveAt(lstDanhsach.SelectedIndices[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = lbDanhSachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhSachChon.Items.RemoveAt(lbDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
