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
        private PictureBox[] picMark = new PictureBox[5];
        private Comment comments;
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
            textTime.Text = detailMovie.startTime.ToString();
            try
            {
                picturePoster.Image = Image.FromFile(detailMovie.logoPath);
            }
            catch (Exception)
            {

                picturePoster.Image = null;
            }

            comments = new Comment();
            comments.getFilmComments(detailMovie.id);
            labelRemark1.Text = Convert.ToString(comments.comments[0]);
            labelRemark2.Text = Convert.ToString(comments.comments[1]);
          
            picMark[0] = pictureBox1;
            picMark[1] = pictureBox2;
            picMark[2] = pictureBox3;
            picMark[3] = pictureBox4;
            picMark[4] = pictureBox5;

            for (int i = 0; i < 5 ; i ++)
            {
                picMark[i].Click += movieMark;
                picMark[i].MouseMove += movieOver;
            }
            groupBox1.MouseMove += movieOver;
            groupBox1.Click += movieMark;

            DataTable dt = this.detailMovie.getUserMark().Tables[0];
            double sum_score = 0;
            int count = dt.Rows.Count;
            foreach (DataRow r in dt.Rows)
            {
                sum_score += Convert.ToDouble(r["score"]);
            }
            if (count == 0)
                this.detailMovie.score = 0;
            else
                this.detailMovie.score = 1.0 * sum_score / count;

            clearMark();

            if (user.type == 0)
            {
                
            }
            else
            {
                this.button.Visible = false;
                this.buttonbuyticket.Visible = false;
            }
        }
        private void movieMark(object sender, EventArgs e)
        {
            int x = MousePosition.X - this.Left - groupBox1.Left - picMark[0].Left;
            int ind = x / (picMark[1].Left - picMark[0].Left);
            int shift = x - ind * (picMark[1].Left - picMark[0].Left);
            if (ind >= 5)
            {
                ind = 4;
                shift = 0;
            }
            if (ind < 0)
            {
                ind = 0;
                shift = 0;
            }
            float mark = ind;
            if (shift >= (picMark[1].Right - picMark[1].Left) / 2)
                mark += 0.5F;

            if (Mark.mark(user.id, detailMovie.id, mark))
            {
                MessageBox.Show("评分成功！");
            }
            else
            {
                MessageBox.Show("评分失败！");
            }
        }
        
        private void movieOver(object sender, EventArgs e)
        {
            int x = MousePosition.X - this.Left - groupBox1.Left - picMark[0].Left;
            int ind = x / (picMark[1].Left - picMark[0].Left);
            int shift = x - ind * (picMark[1].Left - picMark[0].Left);
            if (ind >= 5)
            {
                ind = 4;
                shift = 0;
            }
            if (ind < 0)
            {
                ind = 0;
                shift = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                if (i < ind)
                    picMark[i].Image = Resource1.full;
                else
                    picMark[i].Image = Resource1.empty;
            }
            if (shift >= (picMark[1].Right-picMark[1].Left)/2)
                picMark[ind].Image = Resource1.half;
            else
                picMark[ind].Image = Resource1.empty;
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
            new commentForm(user, detailMovie).Show();
        }

        private void clearMark()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < (int)detailMovie.score)
                    picMark[i].Image = Resource1.full;
                else
                    picMark[i].Image = Resource1.empty;
            }
            if (detailMovie.score - (int)detailMovie.score >= 0.5)
                picMark[(int)detailMovie.score].Image = Resource1.half;
            else
                picMark[(int)detailMovie.score].Image = Resource1.empty;
        }


        private void MovieDetail_MouseMove(object sender, MouseEventArgs e)
        {
            clearMark();
        }

        private void MovieDetail_Activated(object sender, EventArgs e)
        {
            comments.getFilmComments(detailMovie.id);
            labelRemark1.Text = Convert.ToString(comments.comments[0]);
            labelRemark2.Text = Convert.ToString(comments.comments[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
