using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodmenu
{
    public partial class Form2 : Form
    {
        //this variable is to copy what is mentionned in the lstItems and txtTotalPrice to the textBox1f2 and listBox1f2
        public Form2(TextBox mytxt, ListBox mylst)
        {
            InitializeComponent();
            textBox1f2.Text = mytxt.Text;
            listBox1f2.Items.AddRange(mylst.Items);           
        }
    
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        //this variable is to provide the current date and time 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }
    }
}
