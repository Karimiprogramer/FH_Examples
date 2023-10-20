using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenSave_Example
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            textBox1.Text= System.IO.File.ReadAllText(openFile.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
            System.IO.File.WriteAllText( saveFile.FileName, textBox1.Text );
        }
    }
}
