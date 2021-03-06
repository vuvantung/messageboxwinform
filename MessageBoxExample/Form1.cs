using MessageBoxExample.Properties;
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

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowBox("Do you want to exit?", "TH�NG B�O SUCCESS",Resources.success_icon_32);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowBox("Do you want to exit?", "TH�NG B�O ERROR", Resources.Error_icon_32);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowBox("Do you want to exit?", "TH�NG B�O WARNING", Resources.Warning_icon_32);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowBox("Do you want to exit?", "TH�NG B�O INFO", Resources.information_icon_32);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           // if(e.KeyCode == Keys.)
            MyMessageBox.ShowBox("Key =" + e.KeyCode);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyMessageBox.ShowBox("Key =" + e.KeyChar);
        }

        private void btnSuccess_KeyDown(object sender, KeyEventArgs e)
        {
            MyMessageBox.ShowBox("Key" + e.KeyCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}