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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            {
                string tendangnhap = txttendangnhap.Text;
                string matkhau = txtmatkhau.Text;

                if (txttendangnhap.Text == "" || txtmatkhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Ketnoi kn = new Ketnoi();
                //COLLATE Latin1_General_BIN phân biệt viết hoa, viết thường.
                string query = "SELECT PhanLoai, TenDangNhap FROM TaiKhoan WHERE TenDangNhap = '" + tendangnhap + "' COLLATE Latin1_General_BIN AND MatKhau = '" + matkhau + "' COLLATE Latin1_General_BIN";


                DataTable dt = kn.laydl(query);


                if (dt.Rows.Count > 0)
                {
                    string PhanLoai = dt.Rows[0]["PhanLoai"].ToString();
                    string TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();

                    // Hiển thị thông báo cho người dùng
                    if (PhanLoai == "CCH")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền chủ cửa hàng!");
                    }
                    else if (PhanLoai == "Nhân viên")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền nhân viên!");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền quản trị viên!");
                    }
                    Trangchu tc = new Trangchu();
                    //tc.Phanquyen(PhanLoai);
                    tc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
