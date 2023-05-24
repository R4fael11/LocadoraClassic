using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class GeneroDAL
    {
        public void InserirGenero(Genero genero)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE -SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO genero(nome)values(@nome)";
            comando.Parameters.Add(new MySqlParameter("@nome",genero.Nome));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();

        }
    }
}



/*
 *          Conexao.Instance.Open();
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
 * 
 * 
 * 
 */



//Faz um CRUD ai?
//INSERT
//DELETE
//UPDATE
//SELECT