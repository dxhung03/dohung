using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Baitaplon.Net.ChildForm
{
    public partial class FmQuenMatKhau : Form
    {
        private int otp;
        public FmQuenMatKhau()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);
                var fromAddress = new MailAddress("demodoan638@gmail.com");
                var toAddress = new MailAddress(txbEmail.Text);
                const string frompass = "rcsw vpod vtjn uhbr";
                const string subject = "Mã OTP";
                string body = otp.ToString();
                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 5000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Mã OTP đã được gửi qua email");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXn_Click(object sender, EventArgs e)
        {
           /* if (otp.ToString().Equals(txbOTP.Text))
            {
                MessageBox.Show("Xác Minh Thành Công");
                string email = txbEmail.Text;
                string query = "Select * from tblQuanLy where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label3.ForeColor = Color.Black;
                    label3.Text = "Mật Khẩu  : " + modify.TaiKhoans(query)[0].MatKhau;
                }
            }
            else
            {
                MessageBox.Show("OTP Không chính xác !!!!");
            }*/
        }
    }
}
