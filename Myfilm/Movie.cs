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
        public DataSet getMovieInfo()
        {
            string sql = @"select * from movie where name like '" + name + "'";
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
        public DataSet getUserMark()
        {
            string sql = string.Format("select userId, score from scores where filmId = '{0}'", this.id);
            return dbHelper.GetDataSet(sql);
        }
        public DataSet getSeats()
        {
            string sql = string.Format("select flag from seat where filmId = '{0}'", this.id);
            return dbHelper.GetDataSet(sql);
        }
        //根据id获得电影信息
        public void getMovieById()
        {
            string sql = @"select * from films where id='" + this.id + "'";
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            if (dr.Read())
            {
                this.name = Convert.ToString(dr["filmname"]);
                this.price = Convert.ToSingle(dr["price"]);
                this.length = Convert.ToSingle(dr["length"]);
                this.description = Convert.ToString(dr["description"]);
                this.director = Convert.ToString(dr["director"]);
                this.hallNum = Convert.ToInt32(dr["hall"]);
                this.startTime = Convert.ToDateTime(dr["startTime"]);
                this.logoPath = Convert.ToString(dr["logo"]);
                this.amount = Convert.ToInt32(dr["amount"]);
                if (dr["score"] != DBNull.Value)
                {
                    this.score = Convert.ToSingle(dr["score"]);
                }
                else
                {
                    this.score = 0;
                }
                dr.Close();
               
            }
        }
    }
}
