using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Planner
{
    public partial class Form1 : Form
    {
        private Class1 currentTask;
        private taskrepo repo;

        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            repo = new taskrepo();
            
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

        private void LoadTask()
        {
            var tasks = repo.GetTasks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connstring = "server=localhost; uid=root; pwd=admin; database=planner";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT task as 'Task', status as 'Status', deadline as 'Deadline', description as 'Description' FROM planner.task_table ;", con);
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
            currentTask = new Class1();

            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            currentTask.task = row.Cells[0].Value.ToString();
            currentTask.status = row.Cells[1].Value.ToString();
            currentTask.deadline = row.Cells[2].Value.ToString();
            currentTask.description = row.Cells[3].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            
            LoadTask();
            repo.DeleteTask(currentTask);

            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(currentTask.task, currentTask.status, currentTask.deadline, currentTask.description);
            this.Hide();
            form3.Show();
        }

    }
}
