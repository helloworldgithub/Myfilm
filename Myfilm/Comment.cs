using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Myfilm
{
    class Comment
    {
        public string[] comments = new string[2];
        public void getFilmComments(int filmId)
        {
            string sql = string.Format("select top 2 comments from comments where filmId = {0}", filmId);
            DataTable dt = dbHelper.GetDataSet(sql).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++ )
            {
                comments[i] = Convert.ToString(dt.Rows[i]["comments"]);
            }
        }
        public string getFilmComments(int filmId, int userId)
        {
            string sql = string.Format("select top 2 comments from comments where filmId = {0} and userId = {1}", filmId,userId);
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            string res = null;
            if (dr.Read())
            {
                res = Convert.ToString(dr["comments"]);
            }
            dr.Close();
            return res;
        }
        public static bool addComment(int filmId, int userId, string comments)
        {
            string sql = string.Format(@"if exists(select 1 from comments where filmId={0} and userId={1})
                                            begin update comments set comments = '{2}' where filmId = {0} and userId = {1} end
                                            else begin insert into comments(filmId, userId, comments) values({0}, {1}, '{2}') end",
                                            filmId, userId, comments);
            return dbHelper.ExecuteCommand(sql) > 0;
        }
    }
}
