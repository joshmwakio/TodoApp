using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


     
       

        private void TaskControl_InsertTaskClicked(object sender, EventArgs e)
        {
            Form3 taskForm = new Form3();
            int index = 0;
            foreach (var ctrl in flowLayoutPanel1.Controls)
            {
                try
                {
                    TaskControl task = (TaskControl)((Control)sender).Parent;
                    TaskControl flowTask = (TaskControl)ctrl;

                    if (task.TaskName == flowTask.TaskName)
                    {
                        index = flowLayoutPanel1.Controls.IndexOf((Control)ctrl);
                    }
                }
                catch(Exception ex)
                {
                    TaskControl task = (TaskControl)((Control)sender).Parent.Parent;
                    TaskControl flowTask = (TaskControl)ctrl;

                    if (task.TaskName == flowTask.TaskName)
                    {
                        index = flowLayoutPanel1.Controls.IndexOf((Control)ctrl);
                    }
                }
               
            }
        
            TaskControl taskControl = new TaskControl();
            DialogResult result=taskForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                taskControl.TaskName = taskForm.TaskName;
                if (flowLayoutPanel1.Controls.Count > 1)
                {
                    flowLayoutPanel1.Controls.Add(taskControl);
                    flowLayoutPanel1.Controls.SetChildIndex(taskControl, index + 1);
                    foreach (var ctrl in flowLayoutPanel1.Controls)
                    {
                        TaskControl task_control = (TaskControl)ctrl;
                        task_control.panel1.Visible = true;
                        task_control.panel2.Visible = true;
                    }

                    var task_Control = (TaskControl)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
                    task_Control.panel1.Visible = false;
                    task_Control.panel2.Visible = false;
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(taskControl);
                }
                taskForm.Dispose();
                taskControl.InsertTaskClicked += TaskControl_InsertTaskClicked;
            }
        
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            //await Task.Delay(700);
            Form3 taskForm = new Form3();
            DialogResult result= taskForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                TaskControl taskControl = new TaskControl();
                taskControl.TaskName = taskForm.TaskName;
                flowLayoutPanel1.Controls.Add(taskControl);
                taskForm.Dispose();
                taskControl.InsertTaskClicked += TaskControl_InsertTaskClicked;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
           
            if (flowLayoutPanel1.Controls.Count > 1)
            {
               
            }
           
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
