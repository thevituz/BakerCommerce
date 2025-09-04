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

    public partial class FormUsuarios : Form
    {
        // Objetos globais:
        Model.Usuario usuario;

        int idSelecionado = 0; // armazenar o id do usuário selecionado p/ apagar ou editar

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagridview:
            dgvUsuario.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txtNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmailCadastro.Text.Length < 7) // a@a.co
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();

                // Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txtNomeCadastro.Text;
                usuarioCadastro.Email = txtEmailCadastro.Text;
                usuarioCadastro.Senha = txtSenhaCadastro.Text;

                // Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txtNomeCadastro.Clear();
                    txtEmailCadastro.Clear();
                    txtSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvUsuario.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbs de edição:
            txtNomeEditar.Text = dgvUsuario.Rows[ls].Cells[1].Value.ToString();
            txtEmailEditar.Text = dgvUsuario.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            lblApagarDescricao.Text = $"Apagar: {dgvUsuario.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar o dgv:
                    AtualizarDgv();

                    // Limpar campos de edição:
                    txtEmailEditar.Clear();
                    txtSenhaEditar.Clear();
                    txtNomeEditar.Clear();

                    // Retornar o idSelecionado para 0
                    idSelecionado = 0;

                    // Retornar o texto padrão do "apagar":
                    lblApagarDescricao.Text = "Selecione o usuário que deseja apagar.";

                    // Desabilitar os grbs:
                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}