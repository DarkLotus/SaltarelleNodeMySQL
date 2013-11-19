using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMySQL
{
    [Imported]
    public class MySQLConnection
    {
        public delegate void QueryListener(Exception error, Dictionary<string, string>[] rows, Dictionary<string, string>[] fields);
        public delegate void MySQLErrorListener(Exception error);


        public void connect(MySQLErrorListener error)
        {
            return;
        }
        public void connect()
        {
            return;
        }
        public MySQLQuery query(string query, QueryListener queryResults)
        {
            return null;
        }

        public MySQLQuery query(string p)
        {
            return null;
        }


        public void end()
        {

        }

        public void end(MySQLErrorListener error)
        {

        }
    }
}
