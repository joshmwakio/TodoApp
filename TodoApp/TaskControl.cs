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
    
    public partial class TaskControl : UserControl
    {
        public delegate void InsertTaskClickedHandler(object sender, EventArgs e);
        public delegate void InsertTaskEventHandler(object sender, EventArgs e);
        public event InsertTaskClickedHandler InsertTaskClicked;
        public event InsertTaskEventHandler RaiseInsertTask;

        private string taskName;

        public string TaskName
        {
           get { return taskName;}
           set 
            {
                taskName = value;
                if (!string.IsNullOrEmpty(taskName))
                {
                    bunifuLabel2.Text = taskName;
                    if (RaiseInsertTask != null)
                    {
                        RaiseInsertTask(this, new EventArgs());
                    }
                }
            }
        }

        //public class TaskInsertEventArgs : EventArgs
        //{
        //    private string todoTaskName;
        //    public string TaskName
        //    {
        //        set { todoTaskName = value; }
        //        get { return todoTaskName; }
        //    }
        //    public TaskInsertEventArgs(string todoTaskName)
        //    {
        //        this.todoTaskName = todoTaskName;
        //        MessageBox.Show(todoTaskName);

        //    }
        
        //}
        public TaskControl()
        {
            InitializeComponent();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.SendToBack();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.SendToBack();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (InsertTaskClicked != null)
            {
                InsertTaskClicked.Invoke(sender, e);
            }
         
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Click(object sender, EventArgs e)
        {
            panel1_Click(sender, e);
        }

        private void bunifuSeparator4_Click(object sender, EventArgs e)
        {

        }
    }
}
