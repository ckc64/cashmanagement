using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSystem
{
    public static class queries
    {
        //para to sa mga redundant Query na gagamitin
        public static String userCredQuery(String type, String u, String p)
        {
            String query = type + " * from userlogin where username = '" + u + "' and userpass='" + p + "'";
            return query;
        }
    }
}
