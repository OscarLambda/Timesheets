using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscarTimeSheetsUI
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Server=GMRMLTV;Database=OscarTimeSheetDB;User Id=sa;Password=GreatMinds110;");
        bool manager = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool correct = false;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_EmployeeLogin";

            command.Parameters.Add(new SqlParameter("@EmployeeId", int.Parse(username.Text)));
            command.Parameters.Add(new SqlParameter("@EmployeePassword", password.Text));

            var returnParameter = command.Parameters.Add("@Exists", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            //DataTable table = new DataTable();

            connection.Open();
            command.ExecuteNonQuery();
            if(int.Parse(returnParameter.Value.ToString()) == 1)
            {
                correct = true;
            }
            
            //dataAdapter.Fill(table);  

            connection.Close();
            if (correct)
            {
                // get employee name
                string employeeName = GetEmployeeName();

                Hide();
                MessageBox.Show("Your login information was correct");
                TimeSheet timeSheet = new TimeSheet(employeeName, int.Parse(username.Text));
                timeSheet.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Sorry, your username or password was incorrect");
            }

        }

        private string GetEmployeeName()
        {
            string employeename = "";

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_GetEmployeeNameFromId";

            command.Parameters.Add(new SqlParameter("@EmployeeId", int.Parse(username.Text)));


            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employeename = reader["First"].ToString();
             
            }

            connection.Close();

            return employeename;
        }
    }
}
