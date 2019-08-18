using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGalaxy
{
    public partial class OTPForm : Form
    {
        public OTPForm()
        {
            InitializeComponent();
            ShowOTP();
            double a = 369.369;
            int b = 10;
            int aint = (int)a;
            //int r = ((int)a )/ b;
            int r = aint / b;
            string strbi = string.Format("{0}", r);
            RTB1.Text = "this is a messagebin!\n" + strbi;
        }
       
        private void GetOTP()
        {
            LBPassword10min.Text = OTPBuilder.GetTenMinOTP();
            LBPassword1s.Text = OTPBuilder.GetOneSecondOTP();
        }
        private void ShowOTP()
        {
                Thread th = new Thread(GetOTP);
                th.IsBackground = true;
                th.Start();
        }
        private void BTNClearRTB1_Click(object sender, EventArgs e)
        {
            RTB1.Text = "";
        }
        private void OTPForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
