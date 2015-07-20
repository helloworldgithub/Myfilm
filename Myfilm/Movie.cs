using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
            string sql = @"select * from movie where name like '" + name + "'";
            return dbHelper.GetDataSet(sql);
        }
        //根据id获得电影信息
        public static Movie getMovieById(int id)
        {
            Movie movie = new Movie();
            string sql = @"select * from films where id='" + id + "'";
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            if (dr.Read())
            {
                movie.name = dr["filmname"].ToString();
                movie.price = (float)dr["price"];
                movie.length = (float)dr["length"];
                movie.description = dr["description"].ToString();
                movie.director = (string)dr["director"];
                movie.hallNum = (int)dr["hall"];
                movie.startTime = (DateTime)dr["startTime"];
                movie.logoPath = (string)dr["logo"];
                movie.amount = (int)dr["amount"];
                movie.score = (float)dr["score"];
                return movie;
            }
            else
            {
                return null;
            }
        }
    }
}
