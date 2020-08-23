﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace DnDClient
{
    class DBAccess
    {
        public List<Character> GetMonsters(String monsterName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStrings.GetConnectionString("MonsterManualDb")))
            {
                return connection.Query<Character>($"select * from Character where Name like '%{monsterName}%';").ToList();
            } 
        }
    }
}