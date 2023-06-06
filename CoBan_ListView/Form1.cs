using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtPhong.Text.Trim()) || txtPhong.Text.Length == 0))
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                ListViewItem item = new ListViewItem(); // Tạo đối tượng item
                item.Text = txtPhong.Text.Trim();
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, txtSoLuongNhanSu.Text.Trim());
                item.SubItems.Add(subitem);

                // Xóa thông tin trên ô textbox
                txtPhong.Clear();
                txtSoLuongNhanSu.Clear();

                txtPhong.Focus();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
                MessageBox.Show("Chưa chọn phần tử cần xóa");
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa hết?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                listView1.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
