using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Somar_a_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNcalc_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TXTa.Text); //converter para inteiro
            int N = Convert.ToInt32(TXTn.Text);

            int soma = 0;
            string somaString = "";

            for (int i = a; i < a + N; i++)
            {
                soma += i; //parametro para a soma de a n

                somaString += i;  //Necessário usar RichTexBox por conta da multilinie
                if (i < a + N - 1)// para colocar os numeros ordenados ( 1+2+3)
                {
                    somaString += " + ";
                }
            }

            TXTresult.Text = $"{somaString} = {soma}"; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
