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
            AbrirFormulario(new FrmProduto());
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCliente());
        }

        private void AbrirFormulario(Form formulario)
        {
            foreach (Form item in PnlFormularios.Controls)
            {
                //Verificar se o formulário que desejo abrir já está aberto
                if (formulario.Name == item.Name)
                {
                    //Se estiver aberto trago ele para frente
                    item.BringToFront();
                    //Finalizar o código pq o formulário já esta aberto
                    return;
                }
            }
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            PnlFormularios.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
            ToolStripSplitButton botao = new ToolStripSplitButton 
            {
                Text = formulario.Text,
                
            };
            SsrJanelas.Items.Add(botao);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
