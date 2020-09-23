using CadMotorista.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadMotorista
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Menu telamenu = new Menu();
            this.Hide();
            telamenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fechando a aplicacao.
        }

        private void labelbase_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxbase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxbase.SelectedIndex == 0) { // o selectedIndex ele pega a posicao que esta cada nome.
                texttransportadora.Text = "MARCELINO JOSE DIAS MARTINS";
                textcnpj.Text = "00.412.375/0016-9";
            }
            else if (comboBoxbase.SelectedIndex == 1) {// combobox na posicao 1. 
                texttransportadora.Text = "DIRECT";
                textcnpj.Text = "DIRECT12345";
            } else if (comboBoxbase.SelectedIndex == 2) { // combobox na posicao 2.
                texttransportadora.Text = "TRC";
                textcnpj.Text = "TRC12345";
            };
        }

        private void labelmodalidade_Click(object sender, EventArgs e)
        {

        }

        private void labeloperacao_Click(object sender, EventArgs e)
        {

        }

        private void textmodalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoperacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelinfordomotorista_Click(object sender, EventArgs e)
        {

        }

        private void labeltransportadora_Click(object sender, EventArgs e)
        {

        }

        private void texttransportadora_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textcnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista();
            motorista.Nome = textnomecompleto.Text;
            motorista.Cpf = textcpf.Text;

            Cadastrodb cadastrodb = new Cadastrodb();
            string msg =cadastrodb.Salvar(motorista);


            textrg.Text = msg;


        }
    }
}
