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
        private User user { get; set; }
        private PictureBox[] picMark;
        public MovieDetail(Movie movie,User user)
        {
            
            InitializeComponent();
            detailMovie = movie;
            this.user = user;
            detailMovie.getMovieById();
            textBoxfilmname.Text = detailMovie.name;
            textBoxdirector.Text = detailMovie.director;
            textBoxhallnum.Text = detailMovie.hallNum.ToString();
            textBoxlength.Text = detailMovie.length.ToString();
            textBoxprice.Text = detailMovie.price.ToString();
            dateTimePicker1.Value = detailMovie.startTime;
            picturePoster.Image = Image.FromFile(detailMovie.logoPath);
            string sql = string.Format("select * from [comments] where filmId='{0}'", detailMovie.id);
            SqlDataReader dr = dbHelper.GetDataReader(sql);
          
            picMark[0] = pictureBox1;
            picMark[1] = pictureBox1;
            picMark[2] = pictureBox1;
            picMark[3] = pictureBox1;
            picMark[4] = pictureBox1;

            for (int i = 0; i < 5 ; i ++)
            {
                picMark[i].Click += movieMark;
                //picMark[i].MouseHover += movieOver;
            }

            DataTable dt = this.detailMovie.getUserMark().Tables[0];
            int sum_score = 0;
            int count = dt.Rows.Count;
            foreach (DataRow r in dt.Rows)
            {
                //sum_score += (int)(dt.Columns[0]);
            }
            double ave_score = 1.0 * sum_score / count;
            for (int i = 0; i < 5; i++)
            {
                if (i < (int)ave_score)
                    picMark[i].Image = Image.FromFile("full.png");
                else
                    picMark[i].Image = Image.FromFile("empty.png");
            }
            if (ave_score - (int)ave_score >= 0.5)
                picMark[(int)ave_score].Image = Image.FromFile("empty.png");
            else
                picMark[(int)ave_score].Image = Image.FromFile("half.png");
        }

        private void movieMark(object sender, EventArgs e)
        {
            int ind = (((PictureBox)sender).Left - picMark[0].Left) / (picMark[1].Left - picMark[0].Left);

        }
        /*
        private void movieOver(object sender, EventArgs e)
        {

        }*/

        private void MovieDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonbuyticket_Click(object sender, EventArgs e)
        {
            new SeatsChooser(detailMovie,user).Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            new comment(user, detailMovie).Show();
        }
    }
}
