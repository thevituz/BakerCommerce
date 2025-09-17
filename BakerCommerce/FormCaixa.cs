using BakerCommerce.Model;
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
    public partial class FormCaixa : Form
    {
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio:
            if (txtComanda.Text.Length == 0)
            {
                MessageBox.Show("Imforme o número da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);

                //Tabela para receber o resutado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarPorFicha();

                // verificar se exitem linhas em, "resultado":
                if (resultado.Rows.Count > 0)
                {
                    //Mostrar no dgv:
                    dgvItens.DataSource = resultado;
                    // Calcular o total e mostrar no lblTotal:
                    lblTotalValor.Text = "R$" + resultado.Compute("Sum(Total_Item)", "True").ToString();
                }
                else
                {
                    //Limpar o dgv:
                    dgvItens.DataSource = null;
                    // Mostrar mensagem de erro:
                    MessageBox.Show("Não existem lançamentos nessa comanda!", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        

        private void chkPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrarComanda.Enabled = chkPagamentoRecebido.Checked;

        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);

                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerra!", "Show!",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtComanda.Clear();
                    dgvItens.DataSource = null;
                    chkPagamentoRecebido.Checked = false;
                    btnEncerrarComanda.Enabled = false;
                    lblValor.Text = "R$: - ";
                }
                else
                {
                    MessageBox.Show("Falha ao encessar a comanda!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}