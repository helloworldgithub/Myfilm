using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfilm
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type { get; set; }

        public bool isValidated()
        {
            string sql = string.Format("select count(*) from user where username='%s'and password='%s' and type='%d",this.username,this.password,this.type);
            return Convert.ToInt32(dbHelper.GetScalar(sql)) == 1;
        }

        public bool isExisting()
        {
            string sql = string.Format("select count(*) from user where username='%s'",this.username);
            return Convert.ToInt32(dbHelper.GetScalar(sql)) > 0;
        }

        public bool register()
        {
            string sql = string.Format("insert into user(name,password,type) values('%s','%s','%d')", this.username, this.password, this.type);
            return dbHelper.ExecuteCommand(sql) > 0;
        }
    }
}
