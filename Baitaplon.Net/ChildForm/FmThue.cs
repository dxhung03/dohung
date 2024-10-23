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
    public partial class FmThue : Form
    {
        public FmThue()
        {
            InitializeComponent();
        }
        private Database db;
        private void button2_Click(object sender, EventArgs e)
        {
            new FmKhachThue(true).ShowDialog();
            LoadDsThue();
        }
        private void FmThue_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDsThue();

        }
        private void LoadDsThue()
        {
            List<CustomParameter> list = new List<CustomParameter>();
            dtgvThue.DataSource = db.SelectData("LoadDanhSachThueSach", list);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tenkh = txbtk.Text.Trim();
            if (!string.IsNullOrEmpty(tenkh))
            {
                List<CustomParameter> lst = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        Name = "@tenkh",
                        Value = tenkh
                    }
                };

                DataTable dt = db.SelectData("tiemkiemtheotenkh", lst);
                dtgvThue.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
