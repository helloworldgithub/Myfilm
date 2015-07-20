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
    
    public partial class SeatsChooser : Form
    {
        private User user { get; set; }
        private int NUM_COLUMNS = 15;
        private int INTERVAL = 15;
        private int WIDTH = 30;
        private int HEIGHT = 30;
        private bool[] choose;

        private Movie movie;
        public SeatsChooser(Movie _movie,User user)
            
        {
            this.user = user;
            InitializeComponent();
            this.movie = _movie;
            this.choose = new bool[movie.amount];

            DataRowCollection res = movie.getSeats().Tables[0].Rows;
            for (int i = 0; i < res.Count; i++)
            {
                int s = (int)res[i]["flag"];
                this.choose[s] = true;

            }

            for (int i = 0; i < movie.amount; i++)
            {
                int x = i % NUM_COLUMNS;
                int y = i / NUM_COLUMNS;
                CheckBox button = new CheckBox();
                button.Appearance = Appearance.Button;
                button.Text = Convert.ToString(i);
                button.Left = x * (WIDTH+INTERVAL) + INTERVAL;
                button.Top = y * (HEIGHT+INTERVAL) + INTERVAL;
                button.Height = HEIGHT;
                button.Width = WIDTH;
                button.Click += F;
                if (choose[i])
                {
                    //button.Checked = true;
                    button.Enabled = false;
                }
                groupBox1.Controls.Add(button);
            }

        }
        private void F(object sender, EventArgs e)
        {
            CheckBox clicked = (CheckBox)sender;
            int seat = Convert.ToInt32(clicked.Text);
            this.choose[seat] = false;
        }
        private void SeatsChooser_Load(object sender, EventArgs e)
        {

        }
        //购买跳到payform中

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> seats = new List<int>();
            for (int i = 0; i < this.movie.amount; i++)
            {
                if (this.choose[i])
                {
                    seats.Add(i);
                }
            }
            new PayForm(movie,user).Show();
        }
    }
}
