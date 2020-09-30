using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace To_Do
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Now;
        List<TaskModel> task = new List<TaskModel>();

        public Form1()
        {
            InitializeComponent();
            LoadData(); 
        }
        private void LoadData()
        {
           // string localDate = dt.ToString("MM/dd/yyyy");
            task = DataAccess.LoadTasks();
            insertToCheckList();
        }

        private void insertToCheckList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = task;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Task"].Width = 300;
            dataGridView1.Columns["Date"].Width = 190;
        }
        private void titlePnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string localDate = dt.ToString("MM/dd/yyyy");
            TaskModel t = new TaskModel();

            t.Task = addTaskTxtBox.Text;
            t.Date = localDate;
            DataAccess.SaveTask(t);
            LoadData();   
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    int x = (int)row.Cells[1].Value;
                    DataAccess.DeleteTask(x);  
                }
            }
            LoadData();
        }

        private void addTaskTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Month.Text = dt.ToString("MMMM");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Month.Text = dt.ToString("MMMM");
            Day.Text = dt.ToString("dd");
            Year.Text = dt.ToString("yyyy");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
