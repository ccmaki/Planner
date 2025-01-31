using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Planner
{
    public partial class Form1 : Form
    {
        public Class1 class1;
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            class1 = new Class1();
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
            if (class1 == null)
            {
                class1 = new Class1();
            }

            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            class1.task = row.Cells[0].Value.ToString();
            class1.status = row.Cells[1].Value.ToString();
            class1.deadline = row.Cells[2].Value.ToString();
            class1.description = row.Cells[3].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "DELETE FROM task_table WHERE task = '" + class1.task + "' AND status = '" + class1.status + "' AND deadline = '" + class1.deadline + "' AND description = '" + class1.description + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();


            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(class1.task, class1.status, class1.deadline, class1.description);
            this.Hide();
            form3.Show();
        }

        public Class1 GetTask()
        {
            return class1;
        }
    }
}
