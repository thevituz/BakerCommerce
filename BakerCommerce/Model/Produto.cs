using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public int IdCategoria { get; set; }     // chave da Categoria
        public int IdRespCadastro { get; set; }  // chave do Usuário logado (quem cadastrou)

        // LISTAR TODOS OS PRODUTOS
        public DataTable Listar()
        {
            string comando = @"SELECT p.id, p.nome, p.preco, c.nome AS categoria, u.nome_completo AS responsavel
                               FROM produtos p
                               INNER JOIN categorias c ON p.id_categoria = c.id
                               INNER JOIN usuarios u ON p.id_resp_cadastro = u.id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);
            return tabela;
        }

        // CADASTRAR NOVO PRODUTO
        public bool Cadastrar()
        {
            string comando = @"INSERT INTO produtos (nome, preco, id_categoria, id_resp_cadastro) 
                               VALUES (@nome, @preco, @id_categoria, @id_resp_cadastro)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // Passando parâmetros
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_resp_cadastro", IdRespCadastro);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                conexaoBD.Desconectar(con);
                return true;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        // MODIFICAR PRODUTO
        public bool Modificar()
        {
            string comando = @"UPDATE produtos 
                               SET nome = @nome, preco = @preco, id_categoria = @id_categoria
                               WHERE id = @id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id", Id);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                conexaoBD.Desconectar(con);
                return true;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        // APAGAR PRODUTO
        public bool Apagar()
        {
            string comando = "DELETE FROM produtos WHERE id = @id";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                conexaoBD.Desconectar(con);
                return true;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}


