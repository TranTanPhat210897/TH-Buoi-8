using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SendMail
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(txtSender.Text.Trim(), txtPassword.Text.Trim());
                //smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;

                using (MailMessage mm = new MailMessage(txtSender.Text.Trim(), txtTo.Text.Trim()))
                {
                    mm.Subject = txtSubject.Text;
                    mm.Body = txtBody.Text;

                    mm.IsBodyHtml = false;



                    smtp.Send(mm);
                    MessageBox.Show("Email sent.", "Message");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
