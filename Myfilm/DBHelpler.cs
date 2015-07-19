using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Myfilm
{
    class DBHelpler
    {       
            public static SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=studb;integrated security=true");
    }
}
