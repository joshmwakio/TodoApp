using Bunifu.UI.WinForms;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //instantiate the separator control using Bunifu.UI.WinForms
            BunifuSeparator bunifuSeparator = new BunifuSeparator();
            //set the location of the control
            bunifuSeparator.Location = new Point(195, 150);
            //set the color for the control
            bunifuSeparator.LineColor = Color.DodgerBlue;
            //set the line style for the separator
            bunifuSeparator.LineStyle = BunifuSeparator.LineStyles.DashDot;
            //add the control to the form
            this.Controls.Add(bunifuSeparator);
        }
    }
}
