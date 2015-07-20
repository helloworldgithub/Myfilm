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
    public partial class comment : Form
    {
        private User user { get; set; }
        private Movie movie { get; set; }
        public comment(User user,Movie movie)
        {
            InitializeComponent();
            
        }

        private void comment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql=string.Format("insert into [comments](userId,filmId,comments) values('{0}','{1}','{2}')",user.id,movie.id,richTextBox1.Text.Trim());
            if(dbHelper.ExecuteCommand(sql)>0)
            {
                MessageBox.Show("提交评论成功");
            }
            else
            {
                MessageBox.Show("提交评论失败");
            }
        }
    }
}
