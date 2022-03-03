using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatronPocket
{
    public partial class PPLogin : Form
    {
        public string conString = "Data Source=DESKTOP-15F4KVJ;Initial Catalog=patronPocket;Integrated Security=True";
        

       
        

        public PPLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if (username.Text == "" || passkey.Text == "")
            {
                MessageBox.Show("Please provide Username AND Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection conn = new SqlConnection(conString);
                string query = "SELECT * FROM customer WHERE username = '" + username.Text + "' AND passkey = '" + passkey.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();
                
                if (dt.Rows.Count == 1)
                {
                    

                    MessageBox.Show("Login Successful!");
                    this.Hide();

                    Form ppDashboard = new PPdashboard(username.Text);
                    ppDashboard.ShowDialog();

                    
                    
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Form ppSignup = new PPSignup();
            ppSignup.Show();
        }

        private void passkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void passkey_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(Convert.ToString(e.KeyCode));
                loginBtn_Click(this, new EventArgs());

            }
        }

        private void PPLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
