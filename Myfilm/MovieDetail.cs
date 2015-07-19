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
    public partial class MovieDetail : Form
    {
        //加载的时候就显示相应的信息
        private Movie detailMovie;
        public MovieDetail(Movie movie)
        {
            InitializeComponent();
            detailMovie = movie;

            detailMovie.getMovieById();
            textBoxfilmname.Text = detailMovie.name;
            textBoxdirector.Text = detailMovie.director;
            textBoxhallnum.Text = detailMovie.hallNum.ToString();
            textBoxlength.Text = detailMovie.length.ToString();
            textBoxprice.Text = detailMovie.price.ToString();
            dateTimePicker1.Value = detailMovie.startTime;
            picturePoster.Image = Image.FromFile(detailMovie.logoPath);
            string sql=@"select * from comments where filmId='"+detailMovie.id+"'";
            SqlDataReader dr = dbHelper.GetDataReader(sql);
            //用两个if语句来显示评论，不能多显示，不知道其他办法
            if(dr.Read())
            {

            }
            if(dr.Read())
            {

            }
        }
        


        private void MovieDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonbuyticket_Click(object sender, EventArgs e)
        {
            new SeatsChooser(detailMovie).Show();
        }
    }
}
