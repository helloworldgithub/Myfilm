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
        public DataSet getMovieInfo()
        {
            string sql = "select * from films where filmName like '" + this.name + "'";
            return dbHelper.GetDataSet(sql);
        }
        public static DataSet getMovies(int top)
        {
            string sql;
            if (top > -1)
                sql  = string.Format("select top {0} * from films ", top);
            else
                sql =  "select * from films";
            return dbHelper.GetDataSet(sql);
        }
        public DataSet getSeats()
        {
            string sql = string.Format("select flag from seat where filmId = '{0}'", this.id);
            return dbHelper.GetDataSet(sql);
        }
    }
}
