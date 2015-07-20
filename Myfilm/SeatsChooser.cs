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
        private bool[] sold;

        private Movie movie;
        public SeatsChooser(Movie _movie,User user)
            
        {
            this.user = user;
            InitializeComponent();
            this.movie = _movie;
            this.sold = new bool[movie.amount];
            this.choose = new bool[movie.amount];

            DataRowCollection res = movie.getSeats().Tables[0].Rows;
            for (int i = 0; i < res.Count; i++)
            {
                int s = (int)res[i]["flag"];
                this.sold[s] = true;
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
                if (sold[i])
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
            if (this.choose[seat])
                this.choose[seat] = false;
            else
                this.choose[seat] = true;
            
        }
        private void SeatsChooser_Load(object sender, EventArgs e)
        {

        }
        //购买跳到payform中
        private Seat getSeats()
        {
            Seat seats = new Seat();
            for (int i = 0; i < this.movie.amount; i++)
            {
                if (this.choose[i])
                {
                    this.choose[i] = true;
                    seats.Add(i);
                }
            }
            return seats;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new PayForm(movie,user,getSeats()).Show();
            this.Hide();
        }
    }
}
