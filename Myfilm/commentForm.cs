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
    public partial class commentForm : Form
    {
        private User user { get; set; }
        private Movie movie { get; set; }
        public commentForm(User user,Movie movie)
        {
            InitializeComponent();
            this.user = user;
            this.movie = movie;
        }

        private void comment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Comment.addComment(movie.id, user.id, richTextBox1.Text))
            {
                MessageBox.Show("提交评论成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("提交评论失败");
            }
        }
    }
}
