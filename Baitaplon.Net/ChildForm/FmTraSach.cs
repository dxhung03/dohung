using Baitaplon.Net.ChildForm;
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

namespace Baitaplon.Net
{
    public partial class FmTraSach : Form
    {
        private Database db;
        public FmTraSach()
        {
            InitializeComponent();
        }
        public void loaddstra()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            dtgvtra.DataSource = db.SelectData("LoadDanhSachThueSach", lst);

        }
        private void FmTraSach_Load(object sender, EventArgs e)
        {
            db = new Database();
            loaddstra();
        }
        public void CapNhatDanhSachTraSach()
        {

            loaddstra();
        }
        private void dtgvtra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvtra.Columns["btnthanhtoan"].Index)
                {
                    var idthuesach = dtgvtra.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    FmThanhtoan formThanhToan = new FmThanhtoan(idthuesach);
                    formThanhToan.ThanhToanThanhCong += FormThanhToan_ThanhToanThanhCong;
                    formThanhToan.ShowDialog();
                }
                if (e.ColumnIndex == dtgvtra.Columns["btnTraSach"].Index)
                {
                    var idthuesach = dtgvtra.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var sotienconlai = dtgvtra.Rows[e.RowIndex].Cells["conlai"].Value.ToString();

                    var lst = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            Name = "@id",
                            Value = idthuesach
                        }
                    };
                    if (sotienconlai == "0")
                    {
                        var kt = db.ExeCute("TraSachThue", lst);
                        if (kt >= 0)
                        {

                            MessageBox.Show("Bạn chắc chắn đã thanh toán hết và muốn trả sách?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            loaddstra();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa thanh toán hết tiền!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
        private void FormThanhToan_ThanhToanThanhCong(object sender, EventArgs e)
        {
            
            CapNhatDanhSachTraSach();
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
                dtgvtra.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
