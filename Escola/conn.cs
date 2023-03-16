using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class conn
    {
        public MySqlConnection gettconnection()
        {
            string conexao = "server=localhost; userID=root; password=; database=escola";

            return new MySqlConnection(conexao);
        }
    }
}
