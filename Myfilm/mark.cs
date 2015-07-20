using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfilm
{
    class Mark
    {
        public static bool mark(int userId, int filmId, float score)
        {
            string sql = string.Format(@"if exists(select 1 from scores where filmId={0} and userId={1})
                                            begin update scores set score = '{2}' where filmId = {0} and userId = {1} end
                                            else begin insert into scores(filmId, userId, score) values({0}, {1}, '{2}') end",
                                filmId, userId, score);
            return dbHelper.ExecuteCommand(sql) > 0;
        }
    }
}
