using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frameworks.Core;
using System.Media;

namespace Game_
{
    public partial class DangerLand : Form
    {
        SoundPlayer music;

        public DangerLand()
        {
            InitializeComponent();
            PBar.Value = 0;
            LoadingPanel.Visible = false;
        }

        private void DangerLand_Load(object sender, EventArgs e)
        {
            music = new SoundPlayer("Music.wav");
            music.Play();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_Click(object sender, EventArgs e)
        {
            LoadingPanel.Visible = true;
        }

        private void dlLOOP_Tick(object sender, EventArgs e)
        {
            if(LoadingPanel.Visible == true)
            {
                PBar.Value += 1;
                PBar.Text = PBar.Value.ToString() + "%";
            }

            if(PBar.Text == "100%")
            {
                 
                dlLOOP.Enabled = false;
                LoadingPanel.Visible = false;
                Level1 newForm = new Level1();
                newForm.ShowDialog();
                this.Close();
            }
        }
    }
}
