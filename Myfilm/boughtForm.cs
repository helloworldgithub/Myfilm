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
    public partial class boughtForm : Form
    {
        private User user;
        public boughtForm(User user)
        {
            InitializeComponent();
            this.user = user;
            dataGridView1.DataSource = user.getTickets();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
