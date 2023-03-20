using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WishList.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WishList.Items.Add("Ninja ZX6R");        
            WishList.Items.Add("Ninja ZX250R");
            WishList.Items.Add("Ninja ZX4RR");
            WishList.Items.Add("Ninja H2");
            WishList.Items.Add("Sigma 250");
            
        }

        private void selectionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionBox.Text = WishList.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WishList.Sorted = true;
        }

        private void CLoseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            Datab.Text = Convert.ToString(WishList.Items.Count);
        }

        private void Datab_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
