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
    public partial class MoviePublish : Form
    {
        public Movie movie { get; set; }
        public MoviePublish()
        {
            InitializeComponent();
            //this.movie = getPublishInfo();
        }

        private void MoviePublish_Load(object sender, EventArgs e)
        {

        }
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

        private void buttonselectpicture_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "*.jpg|*.jpeg|*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path  = openFileDialog.FileName;//path
                this.movie.logoPath = path;
                Image image = Image.FromFile(path);
                pictureBoxlogo.Image = image;
            }
            
        }

        private void buttonpublish_Click(object sender, EventArgs e)
        {

        }
    }

}
