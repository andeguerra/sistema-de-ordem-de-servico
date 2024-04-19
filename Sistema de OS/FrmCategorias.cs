using MySql.Data.MySqlClient;
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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            string sql = "SELECT c.cat_codigo, c.cat_nome, c.cat_descricao FROM categorias AS c;";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dgvTabela.DataSource = dt;
            Conexao.Desconectar();
        }
    }
}
