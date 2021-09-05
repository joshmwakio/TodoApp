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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string TaskName { get; set; }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            TaskName = bunifuTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TaskName = bunifuTextBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ActiveControl = bunifuTextBox1;
        }
    }
}
