
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Myfilm
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type { get; set; }
        public float money { get; set; }
        public bool isValidated()
        {
            string sql = string.Format("select count(*) from [user] where username='{0}'and password='{1}' and type={2}",this.username,this.password,this.type);
            return Convert.ToInt32(dbHelper.GetScalar(sql)) == 1;
        }

        public bool isExisting()
        {
            string sql = string.Format("select count(*) from [user] where username='{0}'",this.username);
            return Convert.ToInt32(dbHelper.GetScalar(sql)) > 0;
        }
        public void getUserByName()
        {
            string sql = string.Format("select * from [user] where username = {0}", this.username);
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            if (dr.Read())
            {
                this.id = Convert.ToInt32(dr["id"]);
                this.password = Convert.ToString(dr["password"]);
                this.type = Convert.ToInt32(dr["type"]);
                this.money = Convert.ToInt32(dr["money"]);
            }
            dr.Close();
        }
        public void getUserById()
        {
            string sql = string.Format("select * from [user] where id = {0}", this.id);
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            if (dr.Read())
            {
                this.username = Convert.ToString(dr["username"]);
                this.password = Convert.ToString(dr["password"]);
                this.type = Convert.ToInt32(dr["type"]);
                this.money = Convert.ToInt32(dr["money"]);
            }
            dr.Close();
        }

        public bool pay(float payment)
        {
            string sql = string.Format("update [user] set [money]={0} where username='{1}'", money - payment, username);
            return dbHelper.ExecuteCommand(sql) > 0;
        }

        public bool register()
        {
            string sql = string.Format("insert into [user](username,password,type) values('{0}','{1}','{2}')", this.username, this.password, this.type);
            return dbHelper.ExecuteCommand(sql) > 0;
        }

        public bool recharge(float charge)
        {
            string sql = string.Format("update [user] set [money]={0} where id={1}", (charge + this.money), id);
            return dbHelper.ExecuteCommand(sql) > 0;
        }

        public DataSet getTickets()
        {
            string sql = string.Format("select * from seat where userId = {0}", id);
            return dbHelper.GetDataSet(sql);
        }

    }
}
