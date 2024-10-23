using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Baitaplon.Net.Database;

namespace Baitaplon.Net.ChildForm
{
    public partial class Fmthemsach : Form
    {
        private string idsach;
        private Database db;
        public Fmthemsach(string idsach)
        {
            InitializeComponent();
            this.idsach = idsach;
        }
        private void Fmthemsach_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDssach();
            Loaddsnxb();
            if (string.IsNullOrEmpty(idsach))
            {
                lbltitle.Text = "Thêm sách mới";
            }
            else
            {
                lbltitle.Text = "Cập nhật sách mới";
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        Name = "@idsach",
                        Value = idsach
                    }
                };
                var sach = db.SelectData("chonsach", lstPara).Rows[0];
                cbbloaisach.SelectedValue = sach["matl"].ToString();
                txbsach.Text = sach["tensach"].ToString();
                txbsl.Text = sach["soluong"].ToString();
                cbbNxb.SelectedValue = sach["manxb"].ToString();
                if (sach["trangthai"].ToString() == "0")
                {
                    cbtt.Checked = true;
                }
                else
                {
                    cbtt.Checked = false;
                }
            }
        }
        private void LoadDssach()
        {
            var db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DataTable dt = db.SelectData("loadDsloaisach", lstPara);
            cbbloaisach.DataSource = dt;
            cbbloaisach.DisplayMember = "tentheloai";
            cbbloaisach.ValueMember = "ID";
            
        }
        private void Loaddsnxb()
        {
            var db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DataTable dt = db.SelectData("loaddsnxb", lstPara);
            cbbNxb.DataSource = dt;
            cbbNxb.DisplayMember = "tennxb";
            cbbNxb.ValueMember = "ID";

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Fmthemsach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
    int nLeftRect,     
    int nTopRect,      
    int nRightRect,    
    int nBottomRect,   
    int nWidthEllipse, 
    int nHeightEllipse 
);
        #endregion

        private void btnxn_Click(object sender, EventArgs e)
        {
            if (cbbloaisach.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = cbbloaisach.SelectedValue.ToString();
            var tensach = txbsach.Text.Trim();
            var trangthai = cbtt.Checked ? 0 : 1;
            int soluong = 0;
            var manxb = cbbNxb.SelectedValue.ToString();
            if (!int.TryParse(txbsl.Text, out soluong) || soluong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng sách !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tensach))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbsach.Select();
                return;
            }
            if (string.IsNullOrEmpty(idsach))
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        Name = "@matl",
                        Value = id
                    },
                    new CustomParameter()
                    {
                        Name = "@tensach",
                        Value = tensach
                    },
                    new CustomParameter()
                    {
                        Name = "@trangthai",
                        Value = trangthai.ToString()
                    },
                    new CustomParameter()
                    {
                        Name = "@soluong",
                        Value = soluong.ToString()
                    },
                    new CustomParameter()
                    {
                        Name = "@manxb",
                        Value = manxb
                    }
                };
                var rs = db.ExeCute("themsach", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm sách thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDssach();

                }
            }
            else
            {
                var Para = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            Name = "@idsach",
                            Value = idsach
                        },

                        new CustomParameter
                        {
                            Name = "@tensach",
                            Value = txbsach.Text
                        },
                         new CustomParameter
                        {
                            Name = "@matl",
                            Value = cbbloaisach.SelectedValue.ToString()
                        },
                        new CustomParameter
                        {
                            Name = "@trangthai",
                            Value = trangthai.ToString()
                        },
                        new CustomParameter
                        {
                            Name = "@soluong",
                            Value = soluong.ToString()
                        },
                        new CustomParameter()
                        {
                            Name = "@manxb",
                            Value = cbbNxb.SelectedValue.ToString()
                        }
                    };
                var kq = db.ExeCute("updatesach", Para);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
