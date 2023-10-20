using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataGridView_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=NORTHWIND;Integrated Security=True";
            SqlCommand SqlCommand = new SqlCommand();
            SqlConnection SqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();

            SqlCommand.Connection = SqlConnection;
            SqlCommand.CommandType = CommandType.Text;
            SqlCommand.CommandText = "SELECT * FROM Employees ORDER BY LastName";

            DataTable Result = new DataTable();
            SqlConnection.Open();
            SqlDataAdapter.SelectCommand = SqlCommand;
            SqlDataAdapter.Fill(Result);
            SqlConnection.Close();
            dataGridView1.DataSource = Result;
        }
    }
}
