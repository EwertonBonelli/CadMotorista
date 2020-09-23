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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btmenucad_Click(object sender, EventArgs e)
        {
            Form1 cadastro = new Form1(); // chamando o windows Form1.cs
            this.Hide();
            cadastro.ShowDialog();
            
        }

        private void btmenupesq_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisacadastro = new Pesquisar(); // chamando o windows forms Pesquisar.cs
            this.Hide();
            pesquisacadastro.ShowDialog();
        }
    }

}
