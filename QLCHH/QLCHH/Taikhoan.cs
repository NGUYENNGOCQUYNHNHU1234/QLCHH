using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCHH
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            DataTable db = kn.laydl("SELECT *FROM TaiKhoan");
            dtgvdanhsach.DataSource = db;
        }

        private void dtgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvdanhsach.SelectedRows.Count > 0)
            {
                string tendangnhap = dtgvdanhsach.SelectedRows[0].Cells[0].Value.ToString();
                txttendangnhap.Text = tendangnhap;
                txtmatkhau.Text = dtgvdanhsach.SelectedRows[0].Cells["MatKhau"].Value.ToString();
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txttendangnhap.Clear();
            txtmatkhau.Clear();
            Ketnoi kn = new Ketnoi();
            string tendangnhap = kn.laydl("SELECT TOP 1 TenDangNhap FROM TaiKhoan ORDER BY TenDangNhap DESC").Rows[0]["TenDangNhap"].ToString();
            txttendangnhap.Text = "NV" + (int.Parse(tendangnhap.Substring(2)) + 1).ToString("D3");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txttendangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }
            DataGridViewRow dongdachon = dtgvdanhsach.SelectedRows[0];

            dongdachon.Cells["TenDangNhap"].Value = txttendangnhap.Text;
            dongdachon.Cells["MatKhau"].Value = txtmatkhau.Text;

            MessageBox.Show("Cập nhật sách thành công!");

            txttendangnhap.Clear();
            txtmatkhau.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmatkhau.PasswordChar = '\0';
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txttendangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }
            Ketnoi kn = new Ketnoi();
            kn.thucthi($"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, PhanLoai) VALUES" +
                        $"('{txtmatkhau}','N'{txttendangnhap}')");

            dtgvdanhsach.DataSource = kn.laydl("SELECT *FROM TaiKhoan;");
            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string tendangnhap = dtgvdanhsach.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xóa tài khoản không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ketnoi kn = new Ketnoi();
                string sql = $"DELETE FROM TaiKhoan WHERE TenDangNhap = '{tendangnhap}'";
                kn.laydl(sql);


                DataTable db = kn.laydl("SELECT *FROM TaiKhoan");
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
    }
}
