using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace DnDClient
{
    class DBAccess
    {
        public string getMonsters()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStrings.GetConnectionString("MonsterManualDb")))
            {
                connection.Query("select * from Character;");
            }
                return "";
        }
    }
}
