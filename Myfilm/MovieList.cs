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
        const int ADMIN = 2;
        const int USER = 1;
        public MoviePublish formPub = new MoviePublish();
        public MovieList(int admin)
        {
            InitializeComponent();
            if (admin == ADMIN)
            {
                buttonPub.Visible = false;
            }
            dataMovieList.DataSource = Movie.getMovies(-1);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.name = textName.Text;
            dataMovieList.DataSource = movie.getMovieInfo();
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            this.formPub.Show();
        }

        private Movie getMovie()
        {
            Movie movie = new Movie();
            DataRow dr = ((DataRowView)dataMovieList.CurrentRow.DataBoundItem).Row;
            movie.id = (int)dr["id"];
            return movie;
        }
        private void dataMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataMovieList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataMovieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new MovieDetail(this.getMovie()).Show();
        }
    }
}
