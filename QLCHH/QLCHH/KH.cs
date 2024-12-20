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
    public partial class KH : Form
    {

        Ketnoi kn = new Ketnoi();
        public KH()
        {
            InitializeComponent();
        }

        private void KH_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu cho ComboBox mã trạng thái
            string sql = "SELECT MaTrangThai, TenTrangThai FROM TrangThaiDonHang";
            cboMatrangthai.DataSource = kn.laydl(sql);
            cboMatrangthai.DisplayMember = "TenTrangThai";
            cboMatrangthai.ValueMember = "MaTrangThai";
            cboMatrangthai.SelectedIndex = -1; // Không chọn giá trị nào ban đầu
        }

        
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển
                string maDonHang = txtMadonhang.Text.Trim();
                string maKhachHang = txtMakhachhang.Text.Trim();
                string ngayDatHang = dateNgaydathang.Value.ToString("yyyy-MM-dd"); // Định dạng ngày
                string maTrangThai = cboMatrangthai.SelectedValue?.ToString(); // Lấy mã trạng thái được chọn

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maDonHang) || string.IsNullOrEmpty(maKhachHang))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(maTrangThai))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái cho đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã khách hàng có tồn tại không
                string sqlCheckCustomer = $"SELECT COUNT(*) FROM QLKH WHERE Makhachhang = N'{maKhachHang}'";
                int customerCount = Convert.ToInt32(kn.laydl(sqlCheckCustomer).Rows[0][0]);

                if (customerCount == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu lệnh SQL để thêm đơn hàng
                string sql = $"INSERT INTO QLDH (MaDonHang, MaKhachHang, NgayDatHang, MaTrangThai) " +
                             $"VALUES (N'{maDonHang}', N'{maKhachHang}', '{ngayDatHang}', N'{maTrangThai}')";

                // Thực thi câu lệnh SQL
                kn.thucthi(sql);

                // Thông báo thành công
                MessageBox.Show("Đơn hàng đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm sạch form
                ClearForm();
            }
            //
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức để làm sạch form
        private void ClearForm()
        {
            txtMadonhang.Clear();
            txtMakhachhang.Clear();
            cboMatrangthai.SelectedIndex = -1; // Đặt lại trạng thái mặc định
            dateNgaydathang.Value = DateTime.Now; // Đặt ngày hiện tại cho DateTimePicker
        }

    }
}


       