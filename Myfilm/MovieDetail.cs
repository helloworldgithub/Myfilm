using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Myfilm
{
    public partial class MovieDetail : Form
    {
        public MovieDetail(Movie movie)
        {
            labelName.Text = movie.name;

            InitializeComponent();
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
