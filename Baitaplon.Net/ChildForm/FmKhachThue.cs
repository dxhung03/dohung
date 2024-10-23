using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Baitaplon.Net.Database;

namespace Baitaplon.Net.ChildForm
{
    public partial class FmKhachThue : Form
    {
        private bool check;
        private Database db;
        public FmKhachThue(bool check)
        {
            InitializeComponent();
            this.check = check;
            db = new Database();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FmThemKH(true).ShowDialog();
            this.Close();
        }
        private void LoadDsSach()
        {
            var db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DataTable dt = db.SelectData("loadDsSachkh", lstPara);
            cbbsach.DataSource = dt;
            cbbsach.DisplayMember = "tensach";
            cbbsach.ValueMember = "ID";
        }
        private void LoadDsKhachHang()
        {
            var db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DataTable dt = db.SelectData("loadDsKH", lstPara);
            cbbKH.DataSource = dt;
            cbbKH.DisplayMember = "tenkh";
            cbbKH.ValueMember = "ID";
        }
        private void FmKhachThue_Load(object sender, EventArgs e)
        {
            var db = new Database();
            LoadDsSach();
            LoadDsKhachHang();
        }

        private void btnXn_Click(object sender, EventArgs e)
        {

            if (cbbsach.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tên sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbKH.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tên khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gia = 0;
            if (!int.TryParse(txbGia.Text, out gia) || gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soluong = 0;
            if (!int.TryParse(txbSL.Text, out soluong) || soluong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng sách cần thuê hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngaythue;
            DateTime ngaytra;
            if (!DateTime.TryParseExact(mtbNgayThue.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaythue))
            {
                MessageBox.Show("Vui lòng nhập ngày thuê hợp lệ theo định dạng dd/MM/yyyy!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParseExact(mtbNgaytra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaytra))
            {
                MessageBox.Show("Vui lòng nhập ngày thuê hợp lệ theo định dạng dd/MM/yyyy!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idsach = cbbsach.SelectedValue.ToString();
            var idkh = cbbKH.SelectedValue.ToString();

            var lstParams = new List<CustomParameter>
    {
        new CustomParameter
        {
            Name = "@masach",
            Value = idsach
        },
        new CustomParameter
        {
            Name = "@makh",
            Value = idkh
        },
        new CustomParameter
        {
            Name = "@datcoc",
            Value = gia.ToString()
        },
        new CustomParameter
        {
            Name = "@soluong",
            Value = soluong.ToString()
        },
        new CustomParameter
        {
            Name = "@ngaythue",
            Value = ngaythue.ToString()
        },
        new CustomParameter
        {
            Name = "@ngaytra",
            Value = ngaytra.ToString()
        }
        };
            var rs = db.ExeCute("themkhachthue", lstParams);

            if (rs >= 0)
            {
                MessageBox.Show("Thuê sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng sách không đủ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
