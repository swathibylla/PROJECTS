using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" UserName and password is not entered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure To stop the application");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.MediumVioletRed;

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumVioletRed;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
}
