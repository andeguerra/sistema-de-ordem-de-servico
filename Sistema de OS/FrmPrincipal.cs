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
            //Criar a variavel do formulario que desejo abrir
            Form produto = new FrmProduto();
            //Varrer o Painel e verificar os formulários abertos
            foreach (Form item in PnlFormularios.Controls)
            {
                //Verificar se o formulário que desejo abrir já está aberto
                if (produto.Name == item.Name)
                {
                    //Se estiver aberto trago ele para frente
                    item.BringToFront();
                    //Finalizar o código pq o formulário já esta aberto
                    return;
                }
            }
            produto.TopLevel = false;
            produto.Dock = DockStyle.Fill;
            PnlFormularios.Controls.Add(produto);
            produto.Show();
            produto.BringToFront();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cliente = new FrmCliente();
            //cliente.Show(this);
            //TopLevel = Externa ou dentro de outro Objeto
            //Padrão é True trocamos para False
            cliente.TopLevel = false;
            //Dock para ocupar toda a area disponivel
            cliente.Dock = DockStyle.Fill;
            //adiciona o formulario inteiro no painel 
            PnlFormularios.Controls.Add(cliente);
            //Mostrar o Formulário
            cliente.Show();
            //Trazer o Formulário para a Frente
            cliente.BringToFront();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
