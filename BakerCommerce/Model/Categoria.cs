using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DataTable ListarCategoria() //Método de listagem (SELECT)
        {
            string comando = "SELECT id AS 'Id', nome AS 'Categoria' FROM categorias";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();

            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);

            return (tabela);
        }
    }
}