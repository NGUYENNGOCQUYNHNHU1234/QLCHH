using System;
using System.Data;
using System.Windows.Forms;

namespace QLCHH
{
    public partial class QLNV : Form
    {
        // Tạo đối tượng KetNoi
        private Ketnoi kn = new Ketnoi();

        public QLNV()
        {
            InitializeComponent();
            LoadData();

            dataQLNV.CellClick += dataQLNV_CellContentClick;
        }

        // Nạp dữ liệu vào DataGridView
        private void LoadData()
        {
            string query = "SELECT MaNV, TenNV, Phai, DiaChi, DienThoai FROM QLNV";
            dataQLNV.DataSource = kn.laydl(query);
        }

        private void dataQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataQLNV.Rows[e.RowIndex];

                // Gán dữ liệu vào TextBox
                txtManhanvien.Text = row.Cells["MaNV"].Value.ToString();
                txtHoten.Text = row.Cells["TenNV"].Value.ToString();
                txtGioitinh.Text = row.Cells["Phai"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSodienthoai.Text = row.Cells["DienThoai"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Sinh mã nhân viên mới
            int maNVmoi = LayMaNhanVienMoi();
            txtManhanvien.Text = "NV" + maNVmoi.ToString("D3");

            txtManhanvien.ReadOnly = true;
            txtHoten.Clear();
            txtGioitinh.Clear();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
        }

        private int LayMaNhanVienMoi()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(MaNV, 3, LEN(MaNV)) AS INT)), 0) + 1 FROM QLNV";
            DataTable dt = kn.laydl(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 1;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(txtGioitinh.Text) ||
                string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtSodienthoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.");
                return;
            }

            string query = $"INSERT INTO QLNV (MaNV, TenNV, Phai, DiaChi, DienThoai) " +
                           $"VALUES ('{txtManhanvien.Text}', N'{txtHoten.Text}', '{txtGioitinh.Text}', N'{txtDiachi.Text}', '{txtSodienthoai.Text}')";
            kn.thucthi(query);
            MessageBox.Show("Thêm nhân viên thành công!");

            LoadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE QLNV SET TenNV = N'{txtHoten.Text}', Phai = '{txtGioitinh.Text}', " +
                           $"DiaChi = N'{txtDiachi.Text}', DienThoai = '{txtSodienthoai.Text}' " +
                           $"WHERE MaNV = '{txtManhanvien.Text}'";

            kn.thucthi(query);
            MessageBox.Show("Sửa thành công!");

            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM QLNV WHERE MaNV = '{txtManhanvien.Text}'";
            kn.thucthi(query);
            MessageBox.Show("Xóa thành công!");

            LoadData();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm!");
                return;
            }

            string query = "";

            if (radioButton1.Checked) // Tìm theo mã nhân viên
            {
                query = $"SELECT MaNV, TenNV, Phai, DiaChi, DienThoai FROM QLNV WHERE MaNV = '{txtTimkiem.Text.Trim()}'";
            }
            else if (radioButton2.Checked) // Tìm theo tên nhân viên
            {
                query = $"SELECT MaNV, TenNV, Phai, DiaChi, DienThoai FROM QLNV WHERE TenNV LIKE N'%{txtTimkiem.Text.Trim()}%'";
            }

            DataTable dt = kn.laydl(query);
            dataQLNV.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào!");
            }
        }
        private void txtManhanvien_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi TextBox txtManhanvien thay đổi
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi RadioButton1 được chọn
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi RadioButton2 được chọn
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi Form QLNV được load
            LoadData(); // Có thể gọi LoadData() để tải dữ liệu ban đầu
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            // Gọi hàm LoadData để nạp dữ liệu vào DataGridView khi Form được load
            LoadData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
