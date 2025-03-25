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
using frameworks.Movement;
using frameworks.Collision;

namespace Game_
{
    public partial class Level2 : Form
    {
        Game game;
        Point boundary;
        Random rand;
        Double enemyCounter = 0;
        bool flg = false;
        PCollision pc;
        int n;
        int top;
        int left;


        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            boundary = new Point(this.Width, this.Height);
            rand = new Random();
            game = new Game();
            game.onAddingGameObject += new EventHandler(assigningControls);
            game.deathSpotted += new EventHandler(removingControls);
            game.addGameObject(Properties.Resources.ezgif_com_gif_maker__19_, ObjectType.player, 100, (this.Height / 2), new keyBoard(20, boundary, Properties.Resources.Ship5_1.Width, Properties.Resources.Ship5_1.Height));
            top = (this.Height / 2);
            left = 100;
            pc = new PCollision(ObjectType.player, ObjectType.sEnemie, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.playerFire, ObjectType.sEnemie, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.playerFire, ObjectType.mEnemie, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.player, ObjectType.bEnemie, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.player, ObjectType.mEnemie, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.player, ObjectType.enemyfire, new DieAction());
            game.addCollisionToList(pc);
            pc = new PCollision(ObjectType.player, ObjectType.health, new DieAction());
            game.addCollisionToList(pc);
        }

        private void removingControls(object sender, EventArgs e)
        {
            this.Controls.Remove((PictureBox)sender);
        }

        private void assigningControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void generatingEnemies()
        {
            if (enemyCounter == 50)
                flg = true;

            if (flg == true)
            {

                n = rand.Next(this.Top, this.Height - 100);
                if (enemyCounter % 80 == 0)
                {
                    game.addGameObject(Properties.Resources.ezgif_com_gif_maker__15_, ObjectType.sEnemie, this.Width, n, new EightDirectional(10, "left"));
                }

                if (enemyCounter % 600 == 0)
                {
                    game.addGameObject(Properties.Resources._2__1___1_, ObjectType.bEnemie, this.Width, this.Top, new EightDirectional(20, "ldDia"));
                }

                if (enemyCounter % 900 == 0)
                {
                    game.addGameObject(Properties.Resources._3__1___1_, ObjectType.bEnemie, this.Left - Properties.Resources._3__1___1_.Width, this.Top, new EightDirectional(20, "rdDia"));
                }
                game.goOutofTheBoundsRemover(this.Left, this.Height, this.Width);

                if (enemyCounter % 60 == 0)
                {
                    game.enemyFire(Properties.Resources.shot6_1, ObjectType.enemyfire, new EightDirectional(15, "left"));
                }

                if (enemyCounter % 1500 == 0)
                {
                    game.addGameObject(Properties.Resources.HP_Bonus, ObjectType.health, this.Width, n, new EightDirectional(15, "left"));
                }

            }
            enemyCounter++;
        }

        private void stopingCondition()
        {
            if (pHealth.Value == 0)
            {
                this.Close();
            }

            else if (DieAction.Score >= 100)
            {
                this.Close();
            }
        }

        private void GameLoop_Tick_1(object sender, EventArgs e)
        {
            pHealth.Value = DieAction.Health;
            scoreLabel.Text = "Score = " + DieAction.Score.ToString();
            generatingEnemies();
            game.verticalEnemy(Properties.Resources.ezgif_com_gif_maker__17_, ObjectType.mEnemie, this.Width - 200, n, new Vertical(5, boundary, "up", Properties.Resources.ezgif_com_gif_maker__17_.Height + 100));
            game.update();
            game.unVisibleGoRemover();
            game.isCollide(left, top);
            stopingCondition();
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            game.keyPressed(e.KeyCode);
            if (e.KeyCode == Keys.Space)
            {
                game.playerFire(Properties.Resources.shot4_exp5, ObjectType.playerFire, new EightDirectional(20,"right"));
            }

            else if (e.KeyCode == Keys.B)
            {
                game.playerFire(Properties.Resources.shot4_exp5, ObjectType.playerFire, new EightDirectional(20, "ruDia"));
            }

            else if (e.KeyCode == Keys.N)
            {
                game.playerFire(Properties.Resources.shot4_exp5, ObjectType.playerFire, new EightDirectional(20, "rdDia"));
            }
        }
    }
}
