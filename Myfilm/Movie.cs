using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Myfilm
{
    public class Movie
    {
        public int id {get; set;}
        public string name { get; set; }
        public string description { get; set; }
        public string director { get; set; }
        public float length { get; set; }
        public int hallNum { get; set; }
        public DateTime startTime { get; set; }
        public string logoPath { get; set; }
        public float price { get; set; }
        public int amount { get; set; }
        public float score { get; set; }
        public static DataSet getMovieInfo(string name)
        {
            string sql = "select * from movie where name like '" + name + "'";
            return dbHelper.GetDataSet(sql);
        }
    }
}
