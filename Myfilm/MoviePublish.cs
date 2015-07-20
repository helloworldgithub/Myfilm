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
    public partial class  MoviePublish : Form
    {
        public Movie movie { get; set; }
        public MoviePublish()
        {
            
            InitializeComponent();
            this.movie = getPublishInfo();
        }

        private void MoviePublish_Load(object sender, EventArgs e)
        {

        }
        //获得发布电影的信息
        public Movie getPublishInfo()
        {
            Movie movie = new Movie();
            movie.name = textBoxname.Text.Trim();
            movie.description = richTextBoxdescription.Text.Trim();
            movie.length = float.Parse(textBoxlength.Text.Trim());
            movie.hallNum = int.Parse(textBoxhall.Text.Trim());
            movie.startTime = dateTimePickerstarttime.Value;
            movie.price = float.Parse(textBoxprice.Text.Trim());
            movie.amount = int.Parse(textBoxamount.Text.Trim());
            movie.score = float.Parse(textBoxscore.Text.Trim());

            return movie;

        }
        //上传图片的功能
        private void buttonselectpicture_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;//打开默认路径就是bin//debug
            openFileDialog.Filter = "*.jpg|*.jpeg|*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path  = openFileDialog.FileName;//path
                this.movie.logoPath = path;
                Image image = Image.FromFile(path);
                pictureBoxlogo.Image = image;//picturebox 图片显示
            }
            
        }
        //发布电影
        private void buttonpublish_Click(object sender, EventArgs e)
        {
            string sql = String.Format("insert into films(filmName,price length,description,director,hall,startTime,logo,amount) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", movie.name,movie.price,movie.length,movie.description,movie.director,movie.hallNum,movie.startTime,movie.logoPath,movie.amount);
            if(dbHelper.ExecuteCommand(sql)>0)
            {
                MessageBox.Show("publish success");
            }
            else
            {
                MessageBox.Show("publish fail");
            }
        }
    }

}
