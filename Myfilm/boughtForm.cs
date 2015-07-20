using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myfilm
{
    public partial class boughtForm : Form
    {
        private User user;
        public boughtForm(User user)
        {
            InitializeComponent();
            this.user = user;
            dataGridView1.DataSource = user.getTickets();
            dataGridView1.Columns[0].Visible = false;
        }

        private Seat getSeat()
        {
            Seat seat = new Seat();
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                seat.Add(dr.Index);
            }
            return seat;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float refund = 0;
            int count = 0;
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                int filmId = Convert.ToInt32(dr.Cells[1].Value);
                int flag = Convert.ToInt32(dr.Cells[2].Value);
                
                if (Seat.Refund(user.id, filmId, flag))
                {
                    Movie movie = new Movie();
                    movie.id = filmId;
                    movie.getMovieById();
                    refund += movie.price;
                    count += 1;
                }
            }
            user.recharge(refund);
            MessageBox.Show(string.Format("成功退票 {0} 张， {1} 元钱！", count, refund));
            dataGridView1.DataSource = user.getTickets();
        }
    }
}
