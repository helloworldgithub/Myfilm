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
    public partial class MovieList : Form
    {
        public User user { get; set; }
        const int ADMIN = 1;
        const int USER = 0;
        public MovieList(User user)
        {
            this.user = user;
            InitializeComponent();
            if (user.type == ADMIN)
            {
                button1.Visible = false;
            }
            else
            {
                buttonPub.Visible = false;
            }
            dataMovieList.DataSource = Movie.getMovies(-1);
            for (int i = 0; i < dataMovieList.Columns.Count; i++)
            {
                dataMovieList.Columns[i].Visible = false;
            }
            dataMovieList.Columns[1].Visible = true;
            dataMovieList.Columns[2].Visible = true;
            dataMovieList.Columns[7].Visible = true;
            dataMovieList.Columns[9].Visible = true;
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.name = textName.Text;
            dataMovieList.DataSource = movie.getMovieInfo();
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            new MoviePublish().Show();
        }

        private Movie getMovie()
        {
            Movie movie = new Movie();
            DataRow dr = ((DataRowView)dataMovieList.CurrentRow.DataBoundItem).Row;
            movie.id = (int)dr["id"];
            movie.getMovieById();
            return movie;
        }
        private void listMovie_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void dataMovieList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataMovieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new MovieDetail(this.getMovie(),user).Show();
        }

        private void MovieList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new boughtForm(user).Show();
        }
    }
}
