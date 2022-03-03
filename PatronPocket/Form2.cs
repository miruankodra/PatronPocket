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
    public partial class PPSignup : Form
    {
        public string conString = "Data Source=DESKTOP-15F4KVJ;Initial Catalog=patronPocket;Integrated Security=True";
        public PPSignup()
        {
            InitializeComponent();
        }

        private void PPSignup_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (newPass.Text == confirmPass.Text && agreement.Checked == true)
            { 
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string phoneNumber = prefix.Text + phone.Text;

                string query = "INSERT INTO customer (firstname, lastname,  username, email, passkey, phone, country, city, birthday, gender) Values ('" + firstname.Text + "', '" + lastname.Text + "', '" + newUsername.Text + "', '" + email.Text + "', '" + newPass.Text + "', '" + phoneNumber + "','" + country.Text + "','" + city.Text + "','" + Birthday.Text + "','" + gender.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your account is now created! Sign In to continue to PocketPATRON.");

                this.Close();

                Form ppLogin = new PPLogin();
                ppLogin.Show();
                
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Form ppLogin = new PPLogin();
            ppLogin.Show();
        }
    }
}
