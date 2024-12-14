using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLCHH
{
    /// <summary>
    /// //Oooooo
    /// </summary>
    public partial class QLH : Form
    {
        public QLH()
        {
            InitializeComponent();
        }

        private void QLH_Load(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            DataTable db = kn.laydl("SELECT *FROM QLHoa");
            dtgvthongtin.DataSource = db;
        }

        private void dtgvthongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvthongtin.SelectedRows.Count > 0)
            {
                string mahoa = dtgvthongtin.SelectedRows[0].Cells[0].Value.ToString();
                txtmahoa.Text = mahoa;
                txttenhoa.Text = dtgvthongtin.SelectedRows[0].Cells["TenHoa"].Value.ToString();
                txtmausac.Text = dtgvthongtin.SelectedRows[0].Cells["MauSac"].Value.ToString();
                nugiaban.Value = decimal.Parse(dtgvthongtin.SelectedRows[0].Cells["GiaBan"].Value.ToString());
                nusoluongton.Value = decimal.Parse(dtgvthongtin.SelectedRows[0].Cells["SoLuongTon"].Value.ToString());

                string ImagePath = Path.Combine(@"D:\mahoa",$"{mahoa}.jpg");
                if (File.Exists(ImagePath))
                {
                    pictureBox1.Image = Image.FromFile(ImagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtmahoa.Clear();
            txttenhoa.Clear();
            txtmausac.Clear();
            nugiaban.Value = 0 ;
            nusoluongton.Value = 0 ;

            Ketnoi kn = new Ketnoi();
            string masach = kn.laydl("SELECT TOP 1 Mahoa FROM QLHoa ORDER BY Mahoa DESC").Rows[0]["Mahoa"].ToString();
            txtmahoa.Text = "HO" + (int.Parse(masach.Substring(2)) + 1).ToString("D3");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtmahoa.Text == "" || txttenhoa.Text == "" || txtmausac.Text == "" || nugiaban.Value == 0||
           nusoluongton.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }

            DataGridViewRow dongdachon = dtgvthongtin.SelectedRows[0];

            dongdachon.Cells["MaHoa"].Value = txtmahoa.Text;
            dongdachon.Cells["TenHoa"].Value = txttenhoa.Text;
            dongdachon.Cells["MauSac"].Value = txtmausac.Text;
            dongdachon.Cells["GiaBan"].Value = nugiaban.Value;
            dongdachon.Cells["SoLuongTon"].Value = nusoluongton.Value;

            MessageBox.Show("Cập nhật thông tin thành công!");

            txtmahoa.Clear();
            txttenhoa.Clear();
            txtmausac.Clear();
            nugiaban.Value = 0;
            nusoluongton.Value =0;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string mahoa = dtgvthongtin.SelectedRows[0].Cells["Mahoa"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xóa thông tin  không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ketnoi kn = new Ketnoi();
                string sql = $"DELETE FROM QLHoa WHERE Mahoa = '{mahoa}'";
                kn.laydl(sql);


                DataTable db = kn.laydl("SELECT * FROM QLHoa");
                dtgvthongtin.DataSource = db;
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtmahoa.Text == "" || txttenhoa.Text == "" || txtmausac.Text == "" || nugiaban.Value == 0 ||
           nusoluongton.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!");
                return;
            }
            Ketnoi kn = new Ketnoi();
            kn.thucthi($"INSERT INTO QLHoa(MaHoa, TenHoa, MauSac, GiaBan, SoLuongTon) VALUES " +
                $"('{txtmahoa.Text}', N'{txttenhoa.Text}', N'{txtmausac.Text}', '{nugiaban.Value}', '{nusoluongton.Value}')");

            dtgvthongtin.DataSource = kn.laydl("SELECT * FROM QLHoa");
            MessageBox.Show("Chỉnh sửa thông tin thành công!");
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            Ketnoi kn = new Ketnoi();
            string sql = "";

            string searchText = txttimkiem.Text.Trim();


            if (rdmahoa.Checked)
            {
                sql = "SELECT * FROM QLHoa WHERE Mahoa LIKE '%" + txttimkiem.Text + "%'";
            }
            else
            {
                sql = "SELECT * FROM QLHoa WHERE TenHoa COLLATE Vietnamese_CI_AI LIKE '%" + txttimkiem.Text + "%'";
            }

            DataTable db = kn.laydl(sql);
            dtgvthongtin.DataSource = db;
            txttimkiem.Clear();
        }
    }
}
