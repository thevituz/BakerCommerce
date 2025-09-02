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
    public partial class FormUsuario : Form
    {
        //Objetos globais
        Model.Usuario usuario;

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
            
        }

        public void AtualizarDgv()
        {
            // Mostrar as informações do banco de dados no datagrid view:
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

            else if (txtEmailCadastro.Text.Length < 7) // @a.co

            {

                MessageBox.Show("O email deve ter no mínimo 7 caracteres.",

                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtSenhaCadastro.Text.Length < 6)

            {

                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",

                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            else {
                // Fazer o cadastro
                Model.Usuario usuarioCadastro = new Model.Usuario();

                // Salvar os valores dos campos nos trabalhos do obj:
                usuarioCadastro.NomeCompleto = txtNomeCadastro.Text;
                usuarioCadastro.Email = txtEmailCadastro.Text;
                usuarioCadastro.Senha = txtSenhaCadastro.Text;

                // Executar o Insert 
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv?
                    AtualizarDgv();

                    // Apagar os campos de cadastro
                    txtNomeCadastro.Clear();
                    txtEmailCadastro.Clear();
                    txtSenhaCadastro.Clear();
                }
                else {
                    MessageBox.Show("Falha ao cadastrar o usuário.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

    }
}

