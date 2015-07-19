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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.clear();
        }
        /// <summary>
        /// 获取输入框里的信息
        /// </summary>
        /// <returns></returns>
        public User getUser()
        {
            User user=new User();
            user.username = textBoxName.Text.Trim();
            user.password = textBoxPassword.Text.Trim();
            user.type = comboType.SelectedIndex;
            return user;
            
        }
       /// <summary>
       /// 清除框里内容
       /// </summary>
        public void clear()
        {   
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            comboType.SelectedIndex = 0;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = this.getUser();

            if (user.username == "" || user.password == ""){
                MessageBox.Show("用户名和密码不能为空！");
            }
            else if (user.isExisting())
            {
                MessageBox.Show("该用户已存在！");

            }
            else
            {
                if (user.register()){
                    MessageBox.Show("注册成功！");
                    this.clear();
                }else{
                    MessageBox.Show("注册失败！");
                }
            }
        }

        private void RegisterAndLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.getUser().isValidated())
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                new MovieList(comboType.SelectedIndex).Show();

            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}
