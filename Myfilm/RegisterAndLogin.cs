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
    public partial class RegisterAndLogin : Form
    {
        public RegisterAndLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取输入框里的信息
        /// </summary>
        /// <returns></returns>
        public User getInfo()
        {
            User user=new User();
            string name = textBoxName.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string type = comboBox1.Text.Trim();
            user.Name = name;
            user.Password = password;
            if (type == "管理员")
            {
                user.Type = 1;
            }
            else
            {
                user.Type = 0;
            }
            return user;
            
        }
        /// <summary>
        /// 判断是否是合法用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool isValidateUser(string name)
        {
            User user = getInfo();
            DBHelpler.conn.Open();
            string sql = "select count(*) from user where username='" + user.Name + "'";
            SqlCommand cmd = new SqlCommand(sql, DBHelpler.conn);
            int i = (int)cmd.ExecuteScalar();
            if (i == 1)
            {
                DBHelpler.conn.Close();
                return true;
            }
            else
            {
                DBHelpler.conn.Close();
                return false;
            }
            
        }
       /// <summary>
       /// 清除框里内容
       /// </summary>
        public void clear()
        { textBoxName.Text = "";
        textBoxPassword.Text = "";
        comboBox1.Text = "";
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = getInfo();

            if (isValidateUser(user.Name))
            {
                MessageBox.Show("already have this user");

            }
            else
            {
                DBHelpler.conn.Open();
                string sql = "insert into user(name,password,type) values('"+user.Name+"','"+user.Password+"','"+user.Type+"')";
                SqlCommand cmd = new SqlCommand(sql, DBHelpler.conn);
                if ((cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("register successfully");
                }
                   //注册成功直接进入
                else
                {
                    MessageBox.Show("register fail");
                    
                }
            }
        }

        private void RegisterAndLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
