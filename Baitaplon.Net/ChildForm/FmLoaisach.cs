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
    public partial class FmLoaisach : Form
    {
        public FmLoaisach()
        {
            InitializeComponent();
        }
        private void LoadDsloaisach()
        {
            try
            {
                var db = new Database();
                List<CustomParameter> lstPara = new List<CustomParameter>();
                DataTable dt = db.SelectData("loadDsloaisach", lstPara);

                if (dt != null)
                {
                    dtgvLoaisach.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FmLoaisach_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDsloaisach();
            dtgvLoaisach.Columns[0].Width = 100;
            dtgvLoaisach.Columns[2].Width = 200;
            dtgvLoaisach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void txbG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private Database db;
        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenloaisach = txbS.Text.Trim();
            var dongia = int.Parse(txbG.Text);
            if (string.IsNullOrEmpty(tenloaisach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                Name = "tenloaisach",
                Value = tenloaisach
            });
            prlist.Add(new CustomParameter
            {
                Name = "dongia",
                Value = dongia.ToString()
            });
            var rs = db.ExeCute("theloaisach", prlist);
            if (rs == -1)
            {
                MessageBox.Show("Thêm sách thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsloaisach();
                txbG.Text = "0";
                txbS.Text = null;
            }
        }
        private int maloaisach = 0;
        private void dtgvLoaisach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maloaisach = int.Parse(dtgvLoaisach.Rows[e.RowIndex].Cells[0].Value.ToString());
                txbS.Text = dtgvLoaisach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbG.Text = dtgvLoaisach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenloaisach = txbS.Text.Trim();
            var dongia = int.Parse(txbG.Text);
            if (maloaisach == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            if (string.IsNullOrEmpty(tenloaisach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                Name = "@id",
                Value = maloaisach.ToString()
            });
            prlist.Add(new CustomParameter
            {
                Name = "tenloaisach",
                Value = tenloaisach
            });
            prlist.Add(new CustomParameter
            {
                Name = "dongia",
                Value = dongia.ToString()
            });
            var rs = db.ExeCute("suasach", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật sách thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsloaisach();
                txbG.Text = "0";
                txbS.Text = null;
                maloaisach = 0;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maloaisach == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xoá", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<Database.CustomParameter>
{
             new Database.CustomParameter { Name = "@id", Value = maloaisach.ToString() }
};

                var rs = db.ExeCute("XoaTheLoaiSach", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xoá sách thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsloaisach();
                    maloaisach = 0;
                    txbS.Text = null;
                    txbG.Text = "0";
                }

            }
        }
    }
}
