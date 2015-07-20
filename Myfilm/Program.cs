using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myfilm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          /**  用来测试用的
           * Movie movie = new Movie();
            movie.name = "a";
            movie.id = 7;
            User user = new User();
            user.username = "123";
           * */
            Application.Run(new formLogin());
        }
    }
}
