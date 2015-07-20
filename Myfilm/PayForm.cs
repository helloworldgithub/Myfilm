using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Myfilm
{
    public partial class PayForm : Form
    {
        private Movie movie { get; set; }
        private User user { get; set; }
        public PayForm(Movie movie,User user)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
           
            string sql = string.Format("select * from [user] where username='{0}'", user.username);
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            if(dr.Read())
            { textBoxleftmoney.Text = Convert.ToString(dr["money"]);
            
            }
            dr.Close();
            dbHelper.Conn.Close();
                  
            string sqlmovie = "select * from films where filmName='" + movie.name + "'";
            SqlDataReader drmovie = dbHelper.GetDataReader(sqlmovie);
            if(drmovie.Read())
            {
                textBoxtotalprice.Text = Convert.ToString(drmovie["price"]);
               
            }
            drmovie.Close();
        }
        

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonpaymonye_Click(object sender, EventArgs e)
        {
            if(user.money<movie.price)
            {
                MessageBox.Show("当前余额不足，请立即充值");
            }
            else
            {
                user.money -= movie.price;
                string sql = string.Format("update [user] set money='{0}' where username='{1}'", user.money, user.username);
                if(dbHelper.ExecuteCommand(sql)>0)
                {
                    MessageBox.Show("您购买票成功");
                }
                else
                {

                }
            }
        }

        private void buttonrecharge_Click(object sender, EventArgs e)
        {
            new RechargeForm(user).Show();
        }
    }
}
