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
    public partial class RechargeForm : Form
    {
        private User user { get; set; }
        public RechargeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void RechargeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            float recharge = Convert.ToSingle(textBoxrecharge.Text.Trim());

            if (user.recharge(recharge))
            {
                MessageBox.Show("充值成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("充值失败！");
            }
        }
    }
}
