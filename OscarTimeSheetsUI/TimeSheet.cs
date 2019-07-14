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
    public partial class TimeSheet : Form
    {
        SqlConnection connection = new SqlConnection("Server=GMRMLTV;Database=OscarTimeSheetDB;User Id=sa;Password=GreatMinds110;");

        DateTime clockInTime;
        DateTime clockOutTime;
        DateTime breakInTime;
        DateTime breakOutTime;
        int totalBreak;

        int id;

        DataTable employeeTimeTable;

        public TimeSheet(string name, int id)
        {
            InitializeComponent();

            this.name.Text = ($"Welcome {name}!");
            this.id = id;
        }

        private void TimeSheet_Load(object sender, EventArgs e)
        {
            employeeTimeTable = new DataTable();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_GetEmployeeTime";

            command.Parameters.Add(new SqlParameter("@employeeId", id));

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.Open();

            adapter.Fill(employeeTimeTable);

            connection.Close();

            dataGridView1.DataSource = employeeTimeTable;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clockin_Click(object sender, EventArgs e)
        {
            breakin.Visible = true;
            clockout.Visible = true;
            clockin.Visible = false;

            clockInTime = DateTime.Now;

            time.Text = $"{clockInTime}";
        }

        private void breakin_Click(object sender, EventArgs e)
        {
            breakout.Visible = true;
            clockout.Visible = false;
            clockin.Visible = false;

            breakInTime = DateTime.Now;

            startbreak.Text = $"{breakInTime}";
        }

        private void breakout_Click(object sender, EventArgs e)
        {
            breakout.Visible = false;
            clockout.Visible = true;
            clockin.Visible = true;

            breakOutTime = DateTime.Now;


            totalBreak += (breakOutTime - breakInTime).Minutes; //milliseconds for debugging...change to minutes when finished

            endbreak.Text = $"{breakOutTime}";

            totaltime.Text = $"Your total break time is {totalBreak} minutes";
        }

        private void clockout_Click(object sender, EventArgs e)
        {
            clockin.Visible = true;
            clockout.Visible = false;
            breakin.Visible = false;

            clockOutTime = DateTime.Now;

            endtime.Text = $"{clockOutTime}";

            //call the stored proc for adding time

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_AddEmployeeTime";
            
            command.Parameters.Add(new SqlParameter("@startTime", clockInTime));
            command.Parameters.Add(new SqlParameter("@endTime", clockOutTime));
            command.Parameters.Add(new SqlParameter("@break", totalBreak));
            command.Parameters.Add(new SqlParameter("@employeeId", id));

            connection.Open();
            command.ExecuteNonQuery();            
            connection.Close();

            MessageBox.Show("Added Time");
        }
    }
}
