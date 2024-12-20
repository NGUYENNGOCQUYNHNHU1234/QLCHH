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
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            DataTable db = kn.laydl("SELECT * FROM QLKH");
            dtgvdanhsach.DataSource = db;
        }

        private void dtgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvdanhsach.SelectedRows.Count > 0)
            {
                string makh = dtgvdanhsach.SelectedRows[0].Cells[0].Value.ToString();
                txtmakh.Text = makh;
                txthoten.Text = dtgvdanhsach.SelectedRows[0].Cells["HoTen"].Value.ToString();
                txtdiachi.Text = dtgvdanhsach.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                txtsdt.Text = dtgvdanhsach.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
                txtemail.Text = dtgvdanhsach.SelectedRows[0].Cells["Email"].Value.ToString();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txtemail.Clear();

            Ketnoi kn = new Ketnoi();
            string makh = kn.laydl("SELECT TOP 1 Makhachhang FROM QLKH ORDER BY Makhachhang DESC").Rows[0]["Makhachhang"].ToString();
            txtmakh.Text = "KH" + (int.Parse(makh.Substring(2)) + 1).ToString("D3");
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "" || txthoten.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" ||
            txtemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }

            DataGridViewRow dongdachon = dtgvdanhsach.SelectedRows[0];

            dongdachon.Cells["Makhachhang"].Value = txtmakh.Text;
            dongdachon.Cells["HoTen"].Value = txthoten.Text;
            dongdachon.Cells["DiaChi"].Value = txtdiachi.Text;
            dongdachon.Cells["SoDienThoai"].Value = txtsdt.Text;
            dongdachon.Cells["Email"].Value = txtemail.Text;

            MessageBox.Show("Cập nhật sách thành công!");

            txtmakh.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txtemail.Clear();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "" || txthoten.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" ||
            txtemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }
            Ketnoi kn = new Ketnoi();
            kn.thucthi($"INSERT INTO QLKH (Makhachhang, HoTen, DiaChi, SoDienThoai, Email) VALUES " +
                   $"('{txtmakh.Text}', N'{txthoten.Text}', N'{txtdiachi.Text}', '{txtsdt.Text}', '{txtemail.Text}')");

            // Cập nhật lại DataGridView
            dtgvdanhsach.DataSource = kn.laydl("SELECT * FROM QLKH");
            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string makh = dtgvdanhsach.SelectedRows[0].Cells["Makhachhang"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xóa khách hàng  không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ketnoi kn = new Ketnoi();
                string sql = $"DELETE FROM QLKH WHERE Makhachhang = '{makh}'";
                kn.laydl(sql);


                DataTable db = kn.laydl("SELECT * FROM QLKH");
                dtgvdanhsach.DataSource = db;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng giao diện?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();

                this.Close();
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            string sql = "";

            string searchText = txttimkiem.Text.Trim();


            if (rdmakh.Checked)
            {
                sql = "SELECT * FROM QLKH WHERE Makhachhang LIKE '%" + txttimkiem.Text + "%'";
            }
            else
            {
                sql = "SELECT * FROM QLKH WHERE HoTen COLLATE Vietnamese_CI_AI LIKE '%" + txttimkiem.Text + "%'";
            }

            DataTable db = kn.laydl(sql);
            dtgvdanhsach.DataSource = db;
            txttimkiem.Clear();
        }
    }
}
