using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baitaplon.Net.Properties;

namespace Baitaplon.Net
{
    public partial class FmDangNhap : Form
    {
        private Database db;
        public FmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new Database();
            string username = txbUser.Text;
            string password = txbPass.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập, mật khẩu ");
                return;
            }
            List<Database.CustomParameter> parameters = new List<Database.CustomParameter>();
            parameters.Add(new Database.CustomParameter { Name = "@username", Value = username });
            parameters.Add(new Database.CustomParameter { Name = "@password", Value = password });

            int count = Convert.ToInt32(db.SelectData("SelectUserCount", parameters).Rows[0][0]);

            if (count == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                new FmMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void FmDangNhap_Load(object sender, EventArgs e)
        {
            txbUser.PlaceholderText = "Username";
            txbPass.PlaceholderText = "Password";
            txbUser.TabStop = false;

            txbUser.Text = Properties.Settings.Default.taikhoan;
            txbPass.Text = Properties.Settings.Default.matkhau;
            if (Properties.Settings.Default.taikhoan != "")
            {
                checkBox1.Checked = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbHide_Click(object sender, EventArgs e)
        {
            if (txbPass.PasswordChar == '*')
            {
                pbDhide.BringToFront();
                txbPass.PasswordChar = '\0';
            }
        }

        private void pbDhide_Click(object sender, EventArgs e)
        {
            if (txbPass.PasswordChar == '\0')
            {
                pbHide.BringToFront();
                txbPass.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txbUser.Text != "" && txbPass.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    string tentk = txbUser.Text;
                    string matkhau = txbPass.Text;
                    Properties.Settings.Default.taikhoan = tentk;
                    Properties.Settings.Default.matkhau = matkhau;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }

        }
    }
}
