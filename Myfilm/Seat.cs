using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfilm
{
    public class Seat
    {
        List<int> seats = new List<int>();

        public int Count
        {
            get
            {
                return seats.Count;
            }
        }

        public void Add(int s)
        {
            seats.Add(s);
        }
        public bool Occupy(int userId, int filmId)
        {
            int c = 0;
            foreach (int s in seats)
            {
                string sql = string.Format("insert into seat(userId,filmId,flag) values({0},{1},{2})", userId, filmId, s);
                if (dbHelper.ExecuteCommand(sql) > 0)
                {
                    c += 1;
                }
            }
            return c == seats.Count;
        }
        public static bool Refund(int userId, int filmId,int flag)
        {
            //int c = 0;
            string sql = string.Format("delete from seat where userId = {0} and filmId = {1} and flag = {2}", userId, filmId,flag);
            return dbHelper.ExecuteCommand(sql) > 0;
        }
    }
}
