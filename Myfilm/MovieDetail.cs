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
    public partial class MovieDetail : Form
    {
        public MovieDetail(Movie movie)
        {
            InitializeComponent();
            labelName.Text = movie.name;
            labelDirector.Text = movie.director;
            labelHall.Text = Convert.ToString(movie.hallNum);
            labelLength.Text = Convert.ToString(movie.length);
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
