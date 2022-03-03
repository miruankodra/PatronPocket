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
    public partial class addOutput : Form
    {

        public string conString = "Data Source=DESKTOP-15F4KVJ;Initial Catalog=patronPocket;Integrated Security=True";
        public string username;
        public addOutput(string usr)
        {
            InitializeComponent();
            username = usr;
        }

        

        private void addIncome_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            string theValue = value.Text + currency.Text;
            string query = "INSERT INTO inout_info (inout_type,inout_name,inout_date,inout_value, inout_currency,username) VALUES('OUTCOME', '" + outcomeName.Text + "', '" + outcomeDate.Text + "', '" + value.Text + "', '"+currency.Text+"', '" + username + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            this.Close();
            MessageBox.Show("New Outcome Added!");
        }
    }
}
