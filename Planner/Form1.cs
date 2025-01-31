using MySql.Data.MySqlClient;
using System.Data;

namespace Planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Add f2 = new Add();
            //f2.ShowDialog();
            //f2 = null;
            //this.Show();
            new Add().Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM task_table;", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();

        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM task_table;", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

        }
    }
}
