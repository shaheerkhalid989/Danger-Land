using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using frameworks.Core;

namespace frameworks.Collision
{
    public class DieAction : IAction
    {
        private static int health = 100;
        private static int score = 0;
        public static int Health { get => health; set => health = value; }
        public static int Score { get => score; set => score = value; }

        int count = 0;

        public void doAction(GameObject go1, GameObject go2, IGame IG)
        {
            if(go1.Otype == ObjectType.player && go2.Otype == ObjectType.sEnemie)
            {
                if (Health == 0)
                {
                    go1.PB.Visible = false;
                    IG.deathConfirmation(go1.PB);
                }
                go2.PB.Visible = false;
                IG.deathConfirmation(go2.PB);

                if (Health < 10 || Health == 0)
                    Health -= Health;

                else
                    Health -= 10;
            }

            else if(go1.Otype == ObjectType.sEnemie && go2.Otype == ObjectType.player)
            {
                if (Health == 0)
                {       
                    go2.PB.Visible = false;
                    IG.deathConfirmation(go2.PB);
                }
                go1.PB.Visible = false;
                IG.deathConfirmation(go1.PB);

                if (Health < 10 || Health == 0)
                    Health -= Health;

                else
                    Health -= 10;
            }

            else if(go1.Otype == ObjectType.sEnemie && go2.Otype == ObjectType.playerFire)
            {
                go1.PB.Visible = false;
                go2.PB.Visible = false;
                IG.deathConfirmation(go1.PB);
                IG.deathConfirmation(go2.PB);
                Score += 5;
            }

            else if (go1.Otype == ObjectType.playerFire && go2.Otype == ObjectType.sEnemie)
            {
                go2.PB.Visible = false;
                go1.PB.Visible = false;
                IG.deathConfirmation(go2.PB);
                IG.deathConfirmation(go1.PB);
                Score += 5;
            }

            else if (go1.Otype == ObjectType.player && go2.Otype == ObjectType.bEnemie)
            {
                if (Health == 0)
                {
                    go1.PB.Visible = false;
                    IG.deathConfirmation(go1.PB);
                }
               
                if(Health < 30 || Health == 0)
                {
                    Health -= Health;
                }

                else if (Health > 30)
                {
                    Health -= 30;
                }
            }

            else if (go1.Otype == ObjectType.bEnemie && go2.Otype == ObjectType.player)
            {
                if (Health == 0)
                {
                    go2.PB.Visible = false;
                    IG.deathConfirmation(go2.PB);
                }

                if (Health < 30 || Health == 0)
                {
                    Health -= Health;
                }

                else if(Health > 30)
                {
                    Health -= 30;
                }
            }

            else if (go1.Otype == ObjectType.mEnemie && go2.Otype == ObjectType.playerFire)
            {
                if (count == 3)
                {
                    go1.PB.Visible = false;
                    IG.deathConfirmation(go1.PB);
                    Score += 10;
                }
                go2.PB.Visible = false;
                IG.deathConfirmation(go2.PB);
                count++;
            }

            else if (go1.Otype == ObjectType.playerFire && go2.Otype == ObjectType.mEnemie)
            {
                if (count == 3)
                {
                    go2.PB.Visible = false;
                    IG.deathConfirmation(go2.PB);
                    Score += 10;
                    count = 0;
                }
                go1.PB.Visible = false;
                IG.deathConfirmation(go1.PB);
                count++;
            }

            else if (go1.Otype == ObjectType.player && go2.Otype == ObjectType.mEnemie)
            {
                if (Health == 0)
                {
                    go1.PB.Visible = false;
                    IG.deathConfirmation(go1.PB);
                }
                go2.PB.Visible = false;
                IG.deathConfirmation(go2.PB);

                if (Health < 20 || Health == 0)
                    Health -= Health;

                else
                    Health -= 20;
            }

            else if (go1.Otype == ObjectType.mEnemie && go2.Otype == ObjectType.player)
            {
                if (Health == 0)
                {
                    go2.PB.Visible = false;
                    IG.deathConfirmation(go2.PB);
                }
                go1.PB.Visible = false;
                IG.deathConfirmation(go1.PB);

                if (Health < 20 || Health == 0)
                    Health -= Health;

                else
                    Health -= 20;
            }

            else if (go1.Otype == ObjectType.player && go2.Otype == ObjectType.health)
            {
                go2.PB.Visible = false;
                IG.deathConfirmation(go2.PB);
                Health = 100;
            }

            else if (go1.Otype == ObjectType.health && go2.Otype == ObjectType.player)
            {
                go1.PB.Visible = false;
                IG.deathConfirmation(go1.PB);
                Health = 100;
            }

            else if (go1.Otype == ObjectType.enemyfire && go2.Otype == ObjectType.player)
            {
                if (Health == 0)
                {
                    go2.PB.Visible = false;
                    IG.deathConfirmation(go2.PB);
                }
                go1.PB.Visible = false;
                IG.deathConfirmation(go1.PB);

                if(Health > 0)
                    Health -= 5;
            }

            else if (go1.Otype == ObjectType.player && go2.Otype == ObjectType.enemyfire)
            {
                if (Health == 0)
                {
                    go1.PB.Visible = false;
                    IG.deathConfirmation(go1.PB);
                }
                go2.PB.Visible = false;
                IG.deathConfirmation(go2.PB);

                if (Health > 0)
                    Health -= 5;
            }
        }
    }
}
