using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMySQL
{
    [Imported]
    public class MySQLQuery {
        public int index;

        
        public event Action<MySQLRow, int> Result
        {
            add
            {
            }
            remove
            {
            }
        }

        //[ScriptEvent("on", "removeListener")]
        public event Action End
        {
            add
            {
            }
            remove
            {
            }
        }

    }

}