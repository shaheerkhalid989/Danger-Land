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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Level2Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Level2 newForm = new Level2();
            newForm.ShowDialog();
        }
    }
}
