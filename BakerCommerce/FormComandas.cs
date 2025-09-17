using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        Model.Usuario Usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;
            // Colocar ID do produto no campo do código:
            txtCodProduto.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
            // Colocar o nome do produto no campo informações:
            txtProduto.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txtComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCodProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grbInformações.Enabled = false;
                grbLançamento.Enabled = true;
            }
        }

        private void btnLançar_Click(object sender, EventArgs e)
        {
            // Verificar se a quantidade foi preenchida:
            if(txtQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);
                ordemComanda.IdProduto = int.Parse(txtCodProduto.Text);
                ordemComanda.Quantidade = int.Parse(txtQuantidade.Text);
                ordemComanda.IdResp = Usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetarCampos()
        {
            // Limpar os txt:
            txtCodProduto.Clear();
            txtQuantidade.Clear();
            txtProduto.Clear();
            txtComanda.Clear();

            // Resetar os groupboxes:
            grbLançamento.Enabled = false;
            grbInformações.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}

