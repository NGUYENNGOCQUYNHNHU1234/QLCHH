using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHH
{
    public partial class QLDH : Form
    {
        public QLDH()
        {
            InitializeComponent();
        }

        private void QLDH_Load(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            DataTable db = kn.laydl("SELECT * FROM QLDH");
            dtgvdanhsach.DataSource = db;

            cbtt.Items.Add("Chưa xử lý");
            cbtt.Items.Add("Đang xử lý");
            cbtt.Items.Add("Đã xử lý");
            cbtt.SelectedIndex = 0;
        }

        private void dtgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvdanhsach.SelectedRows.Count > 0)
            {
                string madh = dtgvdanhsach.SelectedRows[0].Cells[0].Value.ToString();
                txtmadh.Text = madh;
                DateTime ngaydathang;
                if (DateTime.TryParse(dtgvdanhsach.SelectedRows[0].Cells["NgayDatHang"].Value.ToString(), out ngaydathang))
                {
                    dtdh.Value = ngaydathang;
                }
                else
                {
                    dtdh.Value = DateTime.Now;
                }
                txtmakh.Text = dtgvdanhsach.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
                cbtt.Text = dtgvdanhsach.SelectedRows[0].Cells["MaTrangThai"].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "" || dtdh.Value == null|| txtmadh.Text == "" || cbtt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }

            DataGridViewRow dongdachon = dtgvdanhsach.SelectedRows[0];

            dongdachon.Cells["MaDonHang"].Value = txtmadh.Text;
            dongdachon.Cells["MaKhachHang"].Value = txtmakh.Text;
            dongdachon.Cells["NgayDatHang"].Value = dtdh.Value;
            dongdachon.Cells["MaTrangThai"].Value = cbtt.Text;

            MessageBox.Show("Cập nhật sách thành công!");

            txtmakh.Clear();
            txtmadh.Clear();
            dtdh.Value = DateTime.Now;
            cbtt.SelectedIndex = -1;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "" || dtdh.Value == null || txtmadh.Text == "" || cbtt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }
            Ketnoi kn = new Ketnoi();
            kn.thucthi($"INSERT INTO QLDH (MaDonHang, MaKhachHang, NgayDatHang, MaTrangThai) VALUES" +
                $"('{txtmadh},'{txtmakh}','{dtdh.Value}','{cbtt.Text}");

            dtgvdanhsach.DataSource = kn.laydl("SELECT * FROM QLDH");
            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string madh = dtgvdanhsach.SelectedRows[0].Cells["MaDonHang"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xóa đơn hàng  không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ketnoi kn = new Ketnoi();
                string sql = $"DELETE FROM QLDH WHERE MaDonHang = '{madh}'";
                kn.laydl(sql);


                DataTable db = kn.laydl("SELECT * FROM QLDH");
                dtgvdanhsach.DataSource = db;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng giao diện?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();

                this.Close();
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            string sql = "";
            string searchText = txttimkiem.Text.Trim(); 

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdmadh.Checked)
            {
                sql = "SELECT * FROM QLDH WHERE MaDonHang LIKE '%" + txttimkiem.Text + "%'"; 
            }
            else if (rdmakh.Checked)
            {
                sql = "SELECT * FROM QLDH WHERE MaKhachHang LIKE '%" + txttimkiem.Text + "%'"; 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm (Mã đơn hàng hoặc Mã khách hàng)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//

            DataTable db = kn.laydl(sql);
            dtgvdanhsach.DataSource = db;
            txttimkiem.Clear();
        }
    }
}
