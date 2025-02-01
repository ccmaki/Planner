using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Planner
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                    string status = "a";
                    if (notStarted.Checked == true)
                    {
                        status = "Not Started";
                    }
                    else if (inProgress.Checked == true)
                    {
                        status = "In Progress";
                    }
                    else if (Completed.Checked == true)
                    {
                        status = "Completed";
                    }
                    string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    if (textBox1.Text != "" && status != "a")
                    {
                        string sql = "INSERT INTO task_table(task, status, deadline, description) VALUES('" + textBox1.Text + "', '" + status + "', '" + dateTimePicker1.Value.ToShortDateString() + "', '" + textBox3.Text + "'); ";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataReader reader = cmd.ExecuteReader();
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

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void task_label_Click(object sender, EventArgs e)
        {

        }
    }
}
