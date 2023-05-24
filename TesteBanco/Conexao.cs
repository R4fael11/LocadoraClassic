using MySql.Data.MySqlClient;

namespace TesteBanco
{
    public class Conexao
    {
        private static MySqlConnection _conn;
        //Verificar a conexão (se existe conexão)
        public static MySqlConnection Instance
        {
            get
            {
                //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com MySQL   //nos parênteses -connection string
                    _conn = new MySqlConnection(@"Server = 127.0.0.1; Database = locadora; Uid = root; Pwd = ;");
                }
                //retorna a conexão
                return _conn;
            }

        }
    }    
}

