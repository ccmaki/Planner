using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class Form3 : Form
    {
        private string task;
        private string status;
        private string deadline;
        private string description;

        public Form3(string task, string status, string deadline, string description)
        {
            InitializeComponent();
            this.task = task;
            this.status = status;
            this.deadline = deadline;
            this.description = description;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = task;
            textBox3.Text = description;

            if (status == "Not Started")
            {
                notStarted.Checked = true;
            }
            else if (status == "In Progress")
            {
                inProgress.Checked = true;
            }
            else if (status == "Completed")
            {
                Completed.Checked = true;
            }
            dateTimePicker1.Value = DateTime.ParseExact(deadline, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None);

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Task field is empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string status1 = "a";
                    if (notStarted.Checked == true)
                    {
                        status1 = "Not Started";
                    }
                    else if (inProgress.Checked == true)
                    {
                        status1 = "In Progress";
                    }
                    else if (Completed.Checked == true)
                    {
                        status1 = "Completed";
                    }
                    string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "UPDATE task_table SET task ='" + textBox1.Text + "', status = '" + status1 + "', deadline = '" + dateTimePicker1.Value.ToShortDateString() + "', description = '" + textBox3.Text + "' WHERE task = '"+task+"' AND status = '"+status+"' AND deadline = '"+deadline+"' AND description = '"+description+"'; ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (textBox1.Text != "" && status != "a")
                    {
                        this.Hide();
                        new Form1().Show();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Task and Status is required", "Please Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        //textBox2.Text = "";
                        con.Close();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
