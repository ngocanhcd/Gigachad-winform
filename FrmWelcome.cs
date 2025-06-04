using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    FrmLogin frmLogin = new FrmLogin();
                    this.Hide();              // Ẩn welcome
                    frmLogin.ShowDialog();   // Chờ login đóng
                    this.Close();
                }));
            });
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void FrmWelcome_Leave(object sender, EventArgs e)
        {

        }
        private void FrmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
