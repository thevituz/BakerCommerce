using BakerCommerce.Model;
using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BakerCommerce.Model
{
    public class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdResp { get; set; }
        
        public DateTime DataAdic { get; set; }
        public bool Situacao { get; set; }

        // Listar (Select na view_fichas)
        public DataTable ListarUsuários()
        {
            string comando = "SELECT id, nome_completo FROM usuarios";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();

            DataTable tabela = new DataTable();


            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return tabela;
        }

        // Cadastrar (Insert na view_fichas)
        public bool Cadastrar()
        {
            string comando = "INSERT INTO ordens_comandas (id_ficha, id_produto, quantidade, id_resp) " +
                             "VALUES (@id_ficha, @id_produto, @quantidade, @id_resp)"; //Comando SQL INSERT

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Parameters.AddWithValue("@id_produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", IdResp);
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public DataTable BuscarPorFicha()
        {
            string comando = "SELECT * FROM view_fichas WHERE Ficha = @IdFicha";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@IdFicha", IdFicha);
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool EncerrarComanda()
        {
            string comando = "UPDATE ordens_comandas SET situacao = 0 " +
                "WHERE id_ficha = @id_ficha AND situacao = 1";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
    }
}


