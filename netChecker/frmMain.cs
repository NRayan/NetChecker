using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netChecker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();

            try
            {
                lblPing.Text = "Ping: " + ping.Send("8.8.8.8").RoundtripTime.ToString();
                lblStatus.Text = ping.Send("8.8.8.8").Status.ToString();
            }
            catch (Exception)
            {
                lblPing.Text = "Ping: 99999";
                lblStatus.Text = "Failed";
            }
        }

        private void tootip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
