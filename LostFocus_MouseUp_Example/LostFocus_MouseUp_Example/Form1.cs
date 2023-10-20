using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LostFocus_MouseUp_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("رویداد موشواره فراخوانی شد");
        }
    }
}
