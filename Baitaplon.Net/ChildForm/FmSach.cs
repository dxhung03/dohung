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
    public partial class FmSach : Form
    {
        private Database db;
        private int rowIndex = -1;
        public FmSach()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Fmthemsach(null).ShowDialog();
            LoadDsSach();
        }
        private void LoadDsSach()
        {
            db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            var dt = db.SelectData("loadDsSach", lstPara);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenSach = txbtk.Text.Trim();
            if (!string.IsNullOrEmpty(tenSach))
            {
                List<CustomParameter> lst = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        Name = "@TenSach",
                        Value = tenSach
                    }
                };

                DataTable dt = db.SelectData("TimKiemTheoTenSach", lst);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FmSach_Load(object sender, EventArgs e)
        {
            LoadDsSach();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idsach = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new Fmthemsach(idsach).ShowDialog();
            LoadDsSach();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + dataGridView1.Rows[rowIndex].Cells["tensach"].Value.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var lstPara = new List<CustomParameter>() {
                    new CustomParameter()
                    {
                        Name = "@idsach",
                        Value = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("xoasach", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDsSach();
                }
            }
        }
    }
}
