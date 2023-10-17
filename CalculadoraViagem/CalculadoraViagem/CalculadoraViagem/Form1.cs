using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpedagio.Enabled = chkpedagio.Checked; // faz com que a caixa de texto do pedágio fique disponivel somente ao checar no checkbox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpedagio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtconsu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            //variaveis do text box do Forms1
            float distancia = float.Parse(txtdist.Text);//converte o numero que o usuario coloca como float
            float vLitro = float.Parse(txtvalor.Text);
            float consumo = float.Parse(txtconsu.Text);
            
            float vPedagio; //Fazer com que o programa entenda que, quando estiver sem dados como valor=0
            if (string.IsNullOrEmpty(txtpedagio.Text))//se a string estiver nula/vazia 
            {
                vPedagio = 0;
            }
            else
            {
                vPedagio = float.Parse(txtpedagio.Text);
            }

            //variaveis para os calculos 
            float qtdLitros;
            float vTotalComb;
            float vTotal;
            float vKm;

            qtdLitros = distancia / consumo;
            vTotalComb = qtdLitros * vLitro;
            vTotal = vTotalComb + vPedagio;
            vKm = vTotal / distancia;

            Form2 segundoForm = new Form2(); //necessário para interligar os 2 forms

            // Define o valor do label no segundo formulário.
            segundoForm.qtdLitros.Text = $" {qtdLitros.ToString("F2")} Litros."; // ToString("Fx") é para imprimir a qnt de casas decimais onde x é a qnt de casas
            segundoForm.vtotalcomb.Text = $" R$ {vTotalComb.ToString("F2")}";
            segundoForm.vtotal.Text = $" R$ {vTotal.ToString("F2")}";
            segundoForm.vkm.Text = $" R$ {vKm.ToString("F2")}";
            
            // Exibe o segundo formulário.
            segundoForm.Show();

            // No form 2 é necessário mudar as variaveis para public pois por padrão vem como privado e terá erro de compatbilidade
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
