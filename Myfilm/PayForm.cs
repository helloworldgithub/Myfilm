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
        private Seat seats;
        private float total_price;
        public PayForm(Movie movie,User user,Seat seats)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
            this.seats = seats;
            this.total_price = movie.price * seats.Count;

            textBoxtotalprice.Text = Convert.ToString(this.total_price);
            textBoxleftmoney.Text = Convert.ToString(user.money);
        }
        

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonpaymonye_Click(object sender, EventArgs e)
        {
            if (user.money < this.total_price)
            {
                MessageBox.Show("当前余额不足，请立即充值");
            }
            else
            {
                if (seats.Occupy(user.id, movie.id) && user.pay(total_price)){
                    MessageBox.Show("购票成功！");
                    this.Close();
                }
                else
                    MessageBox.Show("购票失败！");
            }
        }

        private void buttonrecharge_Click(object sender, EventArgs e)
        {
            new RechargeForm(user).Show();
        }

        private void PayForm_Activated(object sender, EventArgs e)
        {
            user.getUserById();
            textBoxleftmoney.Text = Convert.ToString(user.money);
        }
    }
}
