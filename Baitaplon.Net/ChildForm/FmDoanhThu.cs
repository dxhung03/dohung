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
    public partial class FmDoanhThu : Form
    {
        private Database db;
        public FmDoanhThu()
        {
            InitializeComponent();
        }

        private void FmDoanhThu_Load(object sender, EventArgs e)
        {
            db = new Database();         
        }
        private void loaddsdoanhthu()
        {
            DateTime selectedDate;
            DateTime.TryParseExact(mtbNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out selectedDate);
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    Name = "@ngay",
                    Value = selectedDate.ToString("yyyy-MM-dd")
                }
            };

            DataTable dt = db.SelectData("HienThiDoanhThuTheoNgay", lst);
            dtgvDoanhTHu.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {           
                loaddsdoanhthu();    
        }
    }
}
