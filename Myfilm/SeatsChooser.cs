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
    public partial class SeatsChooser : Form
    {
        private int NUM_COLUMNS;
        public SeatsChooser()
        {
            InitializeComponent();
            for (int i = 0; i <= 20; i++)
            {
                int x = i / NUM_COLUMNS;
                int y = i % NUM_COLUMNS;
                Button button = new Button();
                button.Left = 0;
                button.Top = 0;
                button.Height = 10;
                button.Width = 10;
                Controls.Add(button);
            }
        }

        private void SeatsChooser_Load(object sender, EventArgs e)
        {

        }
    }
}
