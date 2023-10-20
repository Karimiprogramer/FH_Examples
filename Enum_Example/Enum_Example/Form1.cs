using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enum_Example
{
    enum City
    {
        Tehran ,   Ardabil , Tabriz
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(City.Tehran + " is " + (int) City.Tehran);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(City.Ardabil + " is " + (int)City.Ardabil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(City.Tabriz + " is " + (int)City.Tabriz);
        }
    }
}
