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
        public bool Occupy(int userId, int filmId, int hall)
        {
            int c = 0;
            foreach (int s in seats)
            {
                // Hall怎么办？
                string sql = string.Format("insert into seat(userId,filmId,hall,flag) values({0},{1},{2},{3})", userId, filmId, hall, s);
                if (dbHelper.ExecuteCommand(sql) > 0)
                {
                    c += 1;
                }
            }
            return c == seats.Count;
        }
    }
}
