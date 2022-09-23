using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Data
{
    static class SQLHelper
    {
        public static string Connection { get; } = "Data Source=DESKTOP-LQNH57I\\SQLEXPRESS;" +
                                           "Initial Catalog=Neptuno;Integrated Security=true";

    }
}

