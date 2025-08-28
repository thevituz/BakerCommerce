using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DataTable Logar()
        {

            string comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // Substituir os caracteres coringas (@)
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", Senha); // Ainda falta obter o hash!

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

    }
}
