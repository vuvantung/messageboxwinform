using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = MyMessageBox.ShowBox("Do you want to exit?", "TH�NG B�O 1");
            //if (result.Equals("1"))
            //{
            //    MessageBox.Show("OK Button was Clicked");
            //}

            //if (result.Equals("2"))
            //{
            //    MessageBox.Show("Cancel Button was Clicked");
            //}
        }
    }
}