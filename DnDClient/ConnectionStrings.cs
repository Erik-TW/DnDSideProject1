using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DnDClient
{
    class ConnectionStrings
    {
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
