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
        private string path { get; set; }
        public MoviePublish()
        {
            InitializeComponent();
            movie = new Movie();
        }

        private void MoviePublish_Load(object sender, EventArgs e)
        {

        }
        public void getPublishInfo()
        {

            try
            {
                movie.name = textBoxname.Text.Trim();
               
                movie.description = richTextBoxdescription.Text.Trim();
                movie.length = Convert.ToSingle(textBoxlength.Text.Trim());
                MessageBox.Show(movie.length.ToString());
                movie.hallNum = Convert.ToInt32(textBoxhall.Text.Trim());
                movie.startTime = dateTimePickerstarttime.Value;
                movie.price = Convert.ToSingle(textBoxprice.Text.Trim());
                movie.amount = int.Parse(textBoxamount.Text.Trim());
                movie.score = Convert.ToSingle(textBoxscore.Text.Trim());
                movie.director = Convert.ToString(textBoxdirector.Text.Trim());
            }
            catch(Exception e)
            {
                Console.WriteLine("Unable to convert '{0}' to a Single.", e);
            }
            

        }

        private void buttonselectpicture_Click(object sender, EventArgs e)
        {
            
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory =Application.StartupPath;//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "picture(*.jpg)|*.jpg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path  = openFileDialog.FileName;//path
                this.movie.logoPath = path;
                if(path!=null)
                {
                    Image image = Image.FromFile(path);
                    pictureBoxlogo.Image = image;
                }
                
                    
                
            }
            
        }
        //发布电影
        private void buttonpublish_Click(object sender, EventArgs e)
        {
            getPublishInfo();
            
            movie.logoPath = path;
            float price=movie.price;
           
            string sql = string.Format("insert into [films](price,length,hall,amount,startTime,filmName,description,director,logo) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",movie.price,movie.length,movie.hallNum,movie.amount,movie.startTime,movie.name,movie.description,movie.director,movie.logoPath);
            if(dbHelper.ExecuteCommand(sql)>0)
            {
                dbHelper.Conn.Close();
                MessageBox.Show("publish success");
            }
            else
            {
                dbHelper.Conn.Close();
                MessageBox.Show("publish fail");
            }
		}
    }

}
