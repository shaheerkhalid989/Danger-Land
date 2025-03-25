using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Level1 newForm = new Level1();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
