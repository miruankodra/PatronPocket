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
    public partial class PPdashboard : Form
    {
        public string username;
        private void reload ()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();


            string selectCmd = $"SELECT inout_type,inout_name,inout_date,inout_value, inout_currency FROM inout_info WHERE username = '{username}' ";

            sda = new SqlDataAdapter(selectCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            inoutDG.DataSource = dt;

            // Calculating total income, outcome and total after adding new values
            //Set initial values to 0 so the old numbers wont ruin the calculation
            incomeTotal = 0;
            outcomeTotal = 0;
            total = 0;
            //Total income
            string selectInputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'INCOME'";

            sda = new SqlDataAdapter(selectInputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                incomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalIncome = Convert.ToString(incomeTotal);

            //Total outcome
            string selectOutputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'OUTCOME'";

            sda = new SqlDataAdapter(selectOutputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                outcomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalOutcome = Convert.ToString(outcomeTotal);

            // Total

            total = incomeTotal - outcomeTotal;
            string theTotal = Convert.ToString(total);

            // Set the label values
            incomeLbl.Text = totalIncome;
            outcomeLbl.Text = totalOutcome;
            totalLbl.Text = theTotal;
        }
        public PPdashboard(string usr)
        {
            InitializeComponent();
            userLbl.Text = $"{usr}'s Dashboard";
            username = usr;
        }

        public string conString = "Data Source=DESKTOP-15F4KVJ;Initial Catalog=patronPocket;Integrated Security=True";
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        public double incomeTotal;
        public double outcomeTotal;
        public double total;
        public double vk;





        private void button2_Click(object sender, EventArgs e)
        {
            Form addOutput = new addOutput(username);
            addOutput.ShowDialog();
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addIncome = new addIncome(username);
            addIncome.ShowDialog();
            reload();
        }

        private void inoutDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
           
           
           
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            

            string selectCmd = $"SELECT inout_type,inout_name,inout_date,inout_value, inout_currency FROM inout_info WHERE username = '{username}' ";

            sda = new SqlDataAdapter(selectCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            inoutDG.DataSource = dt;

            // Calculating total income, outcome and total after adding new values
            //Set initial values to 0 so the old numbers wont ruin the calculation
            incomeTotal = 0;
            outcomeTotal = 0;
            total = 0;
            //Total income
            string selectInputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'INCOME'";

            sda = new SqlDataAdapter(selectInputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                incomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalIncome = Convert.ToString(incomeTotal);

            //Total outcome
            string selectOutputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'OUTCOME'";

            sda = new SqlDataAdapter(selectOutputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                outcomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalOutcome = Convert.ToString(outcomeTotal);

            // Total

            total = incomeTotal - outcomeTotal;
            string theTotal = Convert.ToString(total);

            // Set the label values
            incomeLbl.Text = totalIncome;
            outcomeLbl.Text = totalOutcome;
            totalLbl.Text = theTotal;

        }

        private void PPdashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            // Filling datagrid on initial load
            string selectCmd = $"SELECT inout_type,inout_name,inout_date,inout_value, inout_currency FROM inout_info WHERE username = '{username}' ";

            sda = new SqlDataAdapter(selectCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            inoutDG.DataSource = dt;

            // Calculating total income, outcome and total in initial load
            //Total income
            string selectInputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'INCOME'";

            sda = new SqlDataAdapter(selectInputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                incomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalIncome = Convert.ToString(incomeTotal);

            //Total outcome
            string selectOutputCmd = $"SELECT inout_value FROM inout_info WHERE username = '{username}' AND inout_type = 'OUTCOME'";

            sda = new SqlDataAdapter(selectOutputCmd, conn);
            sda.SelectCommand.ExecuteNonQuery();

            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                outcomeTotal += Convert.ToDouble(row["inout_value"].ToString());
            }

            string totalOutcome = Convert.ToString(outcomeTotal);

            // Total

            total = incomeTotal - outcomeTotal;
            string theTotal = Convert.ToString(total);

            // Set the label values
            incomeLbl.Text = totalIncome;
            outcomeLbl.Text = totalOutcome;
            totalLbl.Text = theTotal;



            

        }

        private void userLbl_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell oneCell in inoutDG.SelectedCells)
    {
                if (oneCell.Selected)
                {



                    string valueOfCell = inoutDG.SelectedCells[0].Value.ToString();

                    int colIndex = oneCell.ColumnIndex;
                    string colName = inoutDG.Columns[colIndex].Name;

                    if (colName == "inout_type" || colName == "inout_date" || colName == "inout_currency" || colName == "username")
                    {
                        MessageBox.Show("Select another cell to identify row (ex. inout_name)");
                    }
                    else
                    {
                        inoutDG.Rows.RemoveAt(oneCell.RowIndex);
                        SqlConnection conn = new SqlConnection(conString);
                        conn.Open();


                        string deleteQuery = "DELETE FROM inout_info WHERE " + colName + " = '" + valueOfCell + "'";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("INOUT deleted.");
                    }

                }
                    



            }
        }

        
    }
}
