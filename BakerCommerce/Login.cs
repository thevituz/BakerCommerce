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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)

        {

            // Verificar se a pessoa digitou o email e a senha:

            if (lblEmail.Text.Length < 6)

            {

                MessageBox.Show("Digite um e-mail válido!",

                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (lblSenha.Text.Length < 4)

            {

                MessageBox.Show("Digite uma senha válida!",

                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else

            {

                // Prosseguir...

                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário:

                usuario.Email = lblEmail.Text;

                usuario.Senha = lblSenha.Text;

                // Tabela que vai receber o resultado do SELECT (Logar)

                DataTable resultado = usuario.Logar();

                // Verificar se acertou o e-mail e senha.

                if (resultado.Rows.Count == 0)

                {

                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else

                {



                    // Armazenar as infos vindas do bd no objeto "usuário"

                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o MenuPrincipal
                    Form1 menuPrincipal = new Form1(usuario);
                    Hide(); // esconder a janela atual
                    menuPrincipal.ShowDialog(); // mostrar o menuprincipal
                    Show(); // mostrar a tela de login ao sair do menu principal
                }

            }

        }

    }
}
