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
        List<string> listapromedios = new List<string>();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
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
            contador +=  1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string promedios;
            promedios = lblProm.Text;
            listapromedios.Add(contador + ") " + promedios);
            listProm.DataSource = null;
            listProm.DataSource = listapromedios;


            txtNot1.Text = " ";
            txtNot2.Text = " ";
            txtNot3.Text = " ";
            lblProm.Text = "> ";

          
        }

   
        private void btSalir_Click(object sender, EventArgs e)
        {
           lblSalir.Text = "Que tenga un buen día";
        }

        
    }
}
