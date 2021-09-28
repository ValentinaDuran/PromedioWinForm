using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1, num2, num3;
            decimal promedio;
            num1 = System.Convert.ToDecimal(txtNot1.Text);
            num2 = System.Convert.ToDecimal(txtNot2.Text);
            num3 = System.Convert.ToDecimal (txtNot3.Text);

            promedio= (num1+num2+num3)/3;
            lblProm.Text = System.Convert.ToString(promedio);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtNot1.Text = " ";
            txtNot2.Text = " ";
            txtNot3.Text = " ";
            lblProm.Text = "> ";
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
