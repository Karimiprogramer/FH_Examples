using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolStrip_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه پرونده جدید را فشار دادید";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه باز کردن را فشار دادید";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه ذخیره سازی را فشار دادید";
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه چاپ را فشار دادید";
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه بریدن را فشار دادید";
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه رونوشت را فشار دادید";
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه جایگزاری را فشار دادید";
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "دکمه کمک را فشار دادید";
        }
    }
}
