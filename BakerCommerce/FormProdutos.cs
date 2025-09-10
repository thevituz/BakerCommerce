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
    public partial class FormProdutos : Form
    {
        // Usuário logado
        Model.Usuario usuario;
        int idSelecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            ListarCategoriasCmb();
            ListarProdutos();
        }

        
        // LISTAR CATEGORIAS NO COMBOBOX
        
        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            DataTable tabela = categoria.ListarCategoria();

            cmbCategoriaCadastro.Items.Clear();
            cmbCategoriaEditar.Items.Clear();

            foreach (DataRow dr in tabela.Rows)
            {
                // Exemplo no combo: "1 - Salgados"
                cmbCategoriaCadastro.Items.Add($"{dr["Id"]} - {dr["Categoria"]}");
                cmbCategoriaEditar.Items.Add($"{dr["Id"]} - {dr["Categoria"]}");
            }
        }

       
        // LISTAR PRODUTOS NO DATAGRIDVIEW
        
        public void ListarProdutos()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos();

            // Ajuste visual do DataGridView
            //dgvProdutos.Columns["id"].HeaderText = "Código";
            //dgvProdutos.Columns["nome"].HeaderText = "Produto";
            //dgvProdutos.Columns["preco"].HeaderText = "Preço (R$)";
            //dgvProdutos.Columns[""].HeaderText = "Categoria";
            //dgvProdutos.Columns["responsavel"].HeaderText = "Responsável";

            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
        // CADASTRAR PRODUTO
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Trim() == "" || txtPrecoCadastro.Text.Trim() == "" || cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.Produto produto = new Model.Produto
                {
                    Nome = txbNomeCadastro.Text.Trim(),
                    Preco = double.Parse(txtPrecoCadastro.Text.Trim()),
                    IdCategoria = int.Parse(cmbCategoriaCadastro.SelectedItem.ToString().Split('-')[0].Trim()),
                    IdRespCadastro = usuario.Id // Usuário logado
                };

                if (produto.CadastrarProduto())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCamposCadastro();
                    ListarProdutos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpar campos de cadastro
        private void LimparCamposCadastro()
        {
            txbNomeCadastro.Clear();
            txtPrecoCadastro.Clear();
            cmbCategoriaCadastro.SelectedIndex = -1;
        }

        
        // SELECIONAR PRODUTO PARA EDIÇÃO
        
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbs de edição:
            txtNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txtPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            btnApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        
        // EDITAR PRODUTO
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.Produto produto = new Model.Produto
                {
                    Id = idSelecionado,
                    Nome = txtNomeEditar.Text.Trim(),
                    Preco = double.Parse(txtPrecoEditar.Text.Trim()),
                    IdCategoria = int.Parse(cmbCategoriaEditar.SelectedItem.ToString().Split('-')[0].Trim())
                };

                if (produto.EditarProduto())
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCamposEdicao();
                    ListarProdutos();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCamposEdicao()
        {
           
            txtNomeEditar.Clear();
            txtPrecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = -1;
        }

        
        // EXCLUIR PRODUTO
       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    Model.Produto produto = new Model.Produto
                    {
                        Id = idSelecionado,
                    };

                    if (produto.ApagarProduto())
                    {
                        MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCamposEdicao();
                        ListarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void btnCadastrar_Click1(object sender, EventArgs e)
        {
            if (txbNomeCadastro.Text.Trim() == "" || txtPrecoCadastro.Text.Trim() == "" || cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.Produto produto = new Model.Produto
                {
                    Nome = txbNomeCadastro.Text.Trim(),
                    Preco = double.Parse(txtPrecoCadastro.Text.Trim()),
                    IdCategoria = int.Parse(cmbCategoriaCadastro.SelectedItem.ToString().Split('-')[0].Trim()),
                    IdRespCadastro = usuario.Id // Usuário logado
                };

                if (produto.CadastrarProduto())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCamposCadastro();
                    ListarProdutos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
