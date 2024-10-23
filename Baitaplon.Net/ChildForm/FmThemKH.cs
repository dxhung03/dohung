using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Baitaplon.Net.Database;


namespace Baitaplon.Net.ChildForm
{
    public partial class FmThemKH : Form
    {
        private bool check;
        private Database db;
        public FmThemKH(bool check)
        {
            InitializeComponent();
            this.check = check;
        }

        private void FmThemKH_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDsKhachHang();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void LoadDsKhachHang()
        {
            var db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DataTable dt = db.SelectData("loadDsKH", lstPara);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var tenkh = txbTen.Text.Trim();
            var email = TxbEmail.Text.Trim();
            var sdt = int.Parse(txbSDT.Text);
            var diachi = txbDiachi.Text.Trim();
            if (string.IsNullOrEmpty(tenkh))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            var prList = new List<CustomParameter>()
            {
                new CustomParameter
                {
                    Name = "@tenkh",
                    Value = tenkh
                },
                new CustomParameter
                {
                    Name = "@email",
                    Value = email
                },
                new CustomParameter
                {
                    Name = "@sdt",
                    Value = sdt.ToString()
                },
                new CustomParameter
                {
                    Name = "@diachi",
                    Value = diachi
                }
            };
            var rs = db.ExeCute("themkh", prList);
            if (rs == 1)
            {
                MessageBox.Show("Thêm khách hàng thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsKhachHang();
            }
            
        }
    }
}
