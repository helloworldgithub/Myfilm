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
        static const int ADMIN = 2;
        static const int USER = 1;
        public MoviePublish formPub = new MoviePublish();
        public MovieList(int admin)
        {
            if (admin == ADMIN)
            {
                buttonPub.Visible = false;
            }
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            listMovie.DataSource = Movie.getMovieInfo(textName.Text);
            listMovie.DisplayMember = "Table";
        }

        private void buttonPub_Click(object sender, EventArgs e)
        {
            this.formPub.Show();
        }

        private Movie getMovie(){
            Movie movie = new Movie();
            DataRow dr = (DataRow)listMovie.SelectedItem;
            movie.id = dr["id"];
            return movie;
        }
        private void listMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            new MovieDetail(this.getMovie()).Show();
        }
    }
}
