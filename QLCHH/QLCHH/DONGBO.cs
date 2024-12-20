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
    public partial class DONGBO : Form
    {
        Ketnoi kn = new Ketnoi();
        public DONGBO()
        {
            InitializeComponent();
        }

        private void DONGBO_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM QLDH"; // Thay "TenBang" bằng tên bảng của bạn
                DataTable dt = kn.laydl(query);
                dtgDongBo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
