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
    public partial class FmThanhtoan : Form
    {
        private string idthuesach;
        private Database db;
        DataRow dt;
        public FmThanhtoan(string idthuesach)
        {
            InitializeComponent();
            this.idthuesach = idthuesach;
            db = new Database();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadDsHd()
        {
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    Name = "@id",
                    Value = idthuesach
                }
            };
            dt = db.SelectData("loadDsHD", lst).Rows[0];
            lblKH.Text = dt["tenkh"].ToString();
            lblGia.Text = string.Format("{0:N0} VND", int.Parse(dt["dongia"].ToString()));
            lblDatcoc.Text = string.Format("{0:N0} VND", int.Parse(dt["datcoc"].ToString()));
            lblConlai.Text = string.Format("{0:N0} VND", int.Parse(dt["dongia"].ToString()) - int.Parse(dt["datcoc"].ToString()));
        }

        private void FmThanhtoan_Load(object sender, EventArgs e)
        {
            loadDsHd();

        }
        public event EventHandler ThanhToanThanhCong;
        private void btnXn_Click(object sender, EventArgs e)
        {

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    Name = "@id",
                    Value = idthuesach
                },
                new CustomParameter
                {
                    Name = "@tien",
                    Value = txbthanhtoan.Text
                }
 
            };
            var kq = db.ExeCute("ThanhToanTraSach", lst);
            if (kq == 1)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThanhToanThanhCong?.Invoke(this, EventArgs.Empty);
                this.Close();
                loadDsHd();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbthanhtoan_KeyUp(object sender, KeyEventArgs e)
        {
            lblConlai.Text = string.Format("{0:N0} VND", (int.Parse(dt["dongia"].ToString()) - int.Parse(dt["datcoc"].ToString())) - int.Parse(txbthanhtoan.Text.ToString()));
        }
    }
}
