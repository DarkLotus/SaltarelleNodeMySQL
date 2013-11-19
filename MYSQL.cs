using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMySQL
{
    [Imported]
    [IgnoreNamespace]
    [ModuleName("mysql")]
    [ScriptName("mysql")]
    public static class MySQL
    {
        public static MySQLConnection createConnection(JsDictionary<string, string> Params)
        {
            return null;
        }
       /* public static Pool createPool(Dictionary<string, string> Params)
        {
            return null;
        }*/




    }
}
