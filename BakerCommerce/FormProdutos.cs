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
            DataTable tabela = categoria.Listar();

            cmbCategoriaCadastro.Items.Clear();
            cmbCategoriaEditar.Items.Clear();

            foreach (DataRow dr in tabela.Rows)
            {
                // Exemplo no combo: "1 - Salgados"
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

       
        // LISTAR PRODUTOS NO DATAGRIDVIEW
        
        public void ListarProdutos()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();

            // Ajuste visual do DataGridView
            dgvProdutos.Columns["id"].HeaderText = "Código";
            dgvProdutos.Columns["nome"].HeaderText = "Produto";
            dgvProdutos.Columns["preco"].HeaderText = "Preço (R$)";
            dgvProdutos.Columns["categoria"].HeaderText = "Categoria";
            dgvProdutos.Columns["responsavel"].HeaderText = "Responsável";

            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
        // CADASTRAR PRODUTO
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCadastro.Text.Trim() == "" || txtPrecoCadastro.Text.Trim() == "" || cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.Produto produto = new Model.Produto
                {
                    Nome = txtNomeCadastro.Text.Trim(),
                    Preco = double.Parse(txtPrecoCadastro.Text.Trim()),
                    IdCategoria = int.Parse(cmbCategoriaCadastro.SelectedItem.ToString().Split('-')[0].Trim()),
                    IdRespCadastro = usuario.Id // Usuário logado
                };

                if (produto.Cadastrar())
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
            txtNomeCadastro.Clear();
            txtPrecoCadastro.Clear();
            cmbCategoriaCadastro.SelectedIndex = -1;
        }

        
        // SELECIONAR PRODUTO PARA EDIÇÃO
        
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];

                // Preenche os campos da aba Editar
                txtIdEditar.Text = linha.Cells["id"].Value.ToString();
                txtNomeEditar.Text = linha.Cells["nome"].Value.ToString();
                txtPrecoEditar.Text = linha.Cells["preco"].Value.ToString();

                // Seleciona a categoria no ComboBox
                string categoriaSelecionada = linha.Cells["categoria"].Value.ToString();
                for (int i = 0; i < cmbCategoriaEditar.Items.Count; i++)
                {
                    if (cmbCategoriaEditar.Items[i].ToString().Contains(categoriaSelecionada))
                    {
                        cmbCategoriaEditar.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        
        // EDITAR PRODUTO
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdEditar.Text.Trim() == "")
            {
                MessageBox.Show("Selecione um produto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Model.Produto produto = new Model.Produto
                {
                    Id = int.Parse(txtIdEditar.Text),
                    Nome = txtNomeEditar.Text.Trim(),
                    Preco = double.Parse(txtPrecoEditar.Text.Trim()),
                    IdCategoria = int.Parse(cmbCategoriaEditar.SelectedItem.ToString().Split('-')[0].Trim())
                };

                if (produto.Modificar())
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
            txtIdEditar.Clear();
            txtNomeEditar.Clear();
            txtPrecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = -1;
        }

        
        // EXCLUIR PRODUTO
       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdEditar.Text.Trim() == "")
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
                        Id = int.Parse(txtIdEditar.Text)
                    };

                    if (produto.Apagar())
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
    }
}
