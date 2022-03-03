using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronPocket
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ppLogin = new PPLogin();
            ppLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ppSignup = new PPSignup();
            ppSignup.Show();
        }
    }
}
