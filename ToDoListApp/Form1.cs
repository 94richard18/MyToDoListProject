using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FunctionLibrary;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            task_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<FunctionLibrary.Tasks> Oldtasks = FunctionLibrary.TasksFunction.LoadTasks();
            task_dataGridView.DataSource = Oldtasks;
            task_dataGridView.Refresh();

            task_dataGridView.CellDoubleClick += TaskDataGridView_CellDoubleClick;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks()
            {
                Task = Task_textbox.Text,
                Description = Description_textBox.Text,
                Urgency = Urgency_combobox.Text,
                Priority = Priority_combobox.Text,
                Deadline = Deadline_timepicker.Value.ToString("yyyy-MM-dd"),
                IsCompleted = 0
            };
            FunctionLibrary.TasksFunction.SaveTasks(tasks);
            List<FunctionLibrary.Tasks> Newtasks = FunctionLibrary.TasksFunction.LoadTasks();
            task_dataGridView.DataSource = Newtasks;
            task_dataGridView.Refresh();

            ClearTextBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TaskDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = task_dataGridView.Rows[e.RowIndex];
            
                Tasks selectedTask = (Tasks)selectedRow.DataBoundItem;

                DetailForm detailform = new DetailForm(selectedTask);
                detailform.Show();
                detailform.FormClosed += (s, args) =>
                {
                    List<Tasks> updateProduct = new List<Tasks>();
                    updateProduct = FunctionLibrary.TasksFunction.LoadTasks();
                    task_dataGridView.DataSource = updateProduct;
                    task_dataGridView.Refresh();
                };


            }
        }

        private void ClearTextBox()
        {
            Task_textbox.Clear();
            Description_textBox.Clear();
            Urgency_combobox.SelectedIndex = -1;
            Priority_combobox.SelectedIndex = -1;
            Deadline_timepicker.Value = DateTime.Now;
        }
    }
}
