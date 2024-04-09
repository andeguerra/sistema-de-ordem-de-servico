using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_OS
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form produto = new FrmProduto();
            // produto.Show();
            produto.Show(this);
            // produto.ShowDialog();
            // produto.ShowDialog(this);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciando o formulário
            Form cliente = new FrmCliente();

            // TopLovel = Fora ou dentro de um Objeto
            cliente.TopLevel = false;

            // DockStyle.Fill = Faz com que preencha toda tela (ou objeto, na qual ele esteja dentro)
            cliente.Dock = DockStyle.Fill;

            // Adiciona o formulário inteiro no painel
            PnlFormularios.Controls.Add(cliente);

            // Mostra o Formulário
            cliente.Show();

            // Tráz o formulpario para frente
            cliente.BringToFront();
        }
    }
}
