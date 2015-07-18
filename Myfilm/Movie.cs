using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Myfilm
{
    class Movie
    {
        public int id {get; set;}
        public string name { get; set; }
        public static DataSet getMovieInfo(string name)
        {
            string sql = "select * from movie where name like '" + name + "'";
            return dbHelper.GetDataSet(name);
        }
    }
}
