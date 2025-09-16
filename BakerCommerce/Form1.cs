using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class Form1 : Form
    {
        // Variáveis globais:
        Model.Usuario usuario = new Model.Usuario();
        public Form1(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblDescricao.Text = $"Olá {usuario.NomeCompleto}, \nEscolha uma opção abaixo:";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuario = new FormUsuarios(usuario);
            formUsuario.ShowDialog(); // Mostrar o form 
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(usuario);
            formProdutos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa FormCaixa = new FormCaixa(usuario);
            FormCaixa.ShowDialog();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FormComandas FormComandas = new FormComandas(usuario);
            FormComandas.ShowDialog();
        }
    }
}
