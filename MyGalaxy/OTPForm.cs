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
            RTB1.Text = "this is a messagebin!\n" ;
        }
       
        private void GetOTP()
        {
            LBPassword10min.Text = OTPBuilder.GetTenMinOTP();
            LBPassword1s.Text = OTPBuilder.GetOneSecondOTP();
        }
        private void BTNClearRTB1_Click(object sender, EventArgs e)
        {
            RTB1.Text = "";
        }
        //private void OTPForm_Load(object sender, EventArgs e)
        //{
        //    Control.CheckForIllegalCrossThreadCalls = false;
        //}
        static string oldstr = null;
        static int itime = 0,jtime=0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            GetOTP();
            jtime++;
            RTB1.Text += OTPBuilder.GetOneSecondOTP()+" ---- "+jtime+"  \n";
            //RTB2.Text += OTPBuilder.GetTenMinOTP() + "\n";
            
            if (OTPBuilder.GetTenMinOTP()!=oldstr)
            {
                itime++;
                RTB2.Text += OTPBuilder.GetTenMinOTP() +" ---- "+itime+ "  \n";
                oldstr= OTPBuilder.GetTenMinOTP();
            }
        }
    }
}
