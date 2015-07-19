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
        private int NUM_COLUMNS = 15;
        private int INTERVAL = 15;
        private int WIDTH = 30;
        private int HEIGHT = 30;
        private bool[] choose;

        private Movie movie;
        public SeatsChooser(Movie _movie)
        {
            InitializeComponent();
            this.movie = _movie;
            this.choose = new bool[movie.amount];
            for (int i = 0; i <= movie.amount; i++)
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
    }
}
