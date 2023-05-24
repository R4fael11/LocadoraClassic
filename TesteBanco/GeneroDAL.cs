using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBanco
{
    public  class GeneroDAL
    {
        public void InserirResponsabilidade()
        {
            Conexao.Instance.Open();
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //Definindo o tipo
            comando.CommandType = System.Data.CommandType.Text;

            //Definindo a DML
            comando.CommandText = "INSERT INTO genero(nome)Values(@nome)";

            //Passando valor para os parâmetros
            comando.Parameters.Add(new MySqlParameter("@nome", "ação"));

            //Executando o comando...

            comando.ExecuteNonQuery();

            Conexao.Instance.Close();
        }

    }
}
