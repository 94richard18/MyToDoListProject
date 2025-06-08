using FunctionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoListApp
{
    public partial class DetailForm : Form
    {
        private bool readOnly = true;
        private Tasks currentTask;
        public DetailForm(Tasks tasks)
        {
            InitializeComponent();
            SetControlsReadonly(readOnly);

            currentTask = tasks;
            SetupText();

        }

        private void Description_Label_Click(object sender, EventArgs e)
        {

        }

        private void tasknameLabel_Click(object sender, EventArgs e)
        {

        }

        private void edit_buttom_Click(object sender, EventArgs e)
        {
            readOnly = !readOnly;
            SetControlsReadonly(readOnly);
        }

        private void delet_buttom_Click(object sender, EventArgs e)
        {
            FunctionLibrary.TasksFunction.DeleteTasks(currentTask);
            this.Close(); 
        }

        private void SetControlsReadonly(bool readOnly)
        {
            Task_textbox.ReadOnly = readOnly;
            Description_textBox.ReadOnly = readOnly;
            Urgency_combobox.Enabled = !readOnly;
            Priority_combobox.Enabled = !readOnly;
            Deadline_timepicker.Enabled = !readOnly;

        }
        private void SetupText()
        {
            Task_textbox.Text = currentTask.Task;
            Description_textBox.Text = currentTask.Description;
            Urgency_combobox.Text = currentTask.Urgency;
            Priority_combobox.Text = currentTask.Priority;
            Deadline_timepicker.Value = DateTime.Parse(currentTask.Deadline);
        }
    }

}
