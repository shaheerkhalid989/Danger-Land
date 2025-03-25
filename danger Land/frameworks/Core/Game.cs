using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using frameworks.Movement;
using frameworks.Collision;

namespace frameworks.Core
{
    public class Game : IGame
    {
        public event EventHandler onAddingGameObject;
        public event EventHandler deathSpotted;

        private List<GameObject> goList;
        private List<PCollision> pcList;

        public List<GameObject> GoList { get => goList; set => goList = value; }
        public List<PCollision> PcList { get => pcList; set => pcList = value; }

        private bool flag = false;
        public bool Flag { get => flag; set => flag = value; }

        public Game()
        {
            goList = new List<GameObject>();
            pcList = new List<PCollision>();
        }

        public void addGameObject(Image img,ObjectType ot, int left, int top, IMovement movement)
        {
            GameObject go = new GameObject(img, ot, left, top, movement);
            GoList.Add(go);
            onAddingGameObject?.Invoke(go.PB, EventArgs.Empty);
        }

        public void verticalEnemy(Image img, ObjectType ot, int left, int top, IMovement movement)
        {
            for (int i = 0; i < GoList.Count; i++)
            {
                if(GoList[i].Movement.GetType() != typeof(Vertical))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (Flag == true)
            {
                addGameObject(img, ot, left, top, movement);
                Flag = false;
            }
                
        }

        public void goOutofTheBoundsRemover(int limitLeft, int limitBottom, int limitRight)
        {
            for(int i = 0; i < GoList.Count; i++)
            {
                if(GoList[i].PB.Left + GoList[i].PB.Width < limitLeft || GoList[i].PB.Top > limitBottom || GoList[i].PB.Left > limitRight)
                {
                    goList.RemoveAt(i);
                }
            }
        }

        public void initializePlayerPosition( int left, int top)
        {
            foreach(GameObject go in GoList)
            {
                if(go.Otype == ObjectType.player)
                {
                    go.PB.Left = left;
                    go.PB.Top = top;
                }
            }
        }

        public void playerFire(Image img, ObjectType ot, IMovement movement)
        {
            for (int i = 0; i < GoList.Count; i++)
            {
                if (GoList[i].Otype == ObjectType.player)
                {
                    addGameObject(img,ot, GoList[i].PB.Location.X, GoList[i].PB.Location.Y, movement);
                }
            }
        }

        public void enemyFire(Image img, ObjectType ot, IMovement movement)
        {
            for (int i = 0; i < GoList.Count; i++)
            {
                if (GoList[i].Movement.GetType() == typeof(Vertical))
                {
                    addGameObject(img, ot, GoList[i].PB.Location.X, GoList[i].PB.Location.Y, movement);
                }
            }
        }

        public void unVisibleGoRemover()
        {
            for (int i = 0; i < GoList.Count; i++)
            {
                if(GoList[i].PB.Visible == false)
                {
                    GoList.RemoveAt(i);
                }
            }
        }

        public void keyPressed(Keys keyCode)
        {
            foreach(GameObject go in GoList)
            {
                if(go.Movement.GetType() == typeof(keyBoard))
                {
                    keyBoard keyBoardHandle = (keyBoard)go.Movement;
                    keyBoardHandle.keyPressedByUser(keyCode);
                }
            }
        }

        public void deathConfirmation(PictureBox pb)
        {
            deathSpotted?.Invoke(pb, EventArgs.Empty);
        }

        public void addCollisionToList(PCollision pc)
        {
            PcList.Add(pc);
        }

        public void isCollide(int left, int top)
        {
            for (int x = 0; x < GoList.Count; x++)
            {
                for (int y = 0; y < GoList.Count; y++)
                {
                    if (GoList[x].PB.Bounds.IntersectsWith(GoList[y].PB.Bounds))
                    {
                        foreach (PCollision pc in PcList)
                        {
                            if (pc.Ot1 == GoList[x].Otype && pc.Ot2 == GoList[y].Otype)
                            {
                                pc.doAction(GoList[x], GoList[y], this);

                                if (GoList[x].Otype == ObjectType.player && GoList[y].Otype == ObjectType.sEnemie)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.sEnemie && GoList[y].Otype == ObjectType.player)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.player && GoList[y].Otype == ObjectType.mEnemie)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.mEnemie && GoList[y].Otype == ObjectType.player)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.player && GoList[y].Otype == ObjectType.bEnemie)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.bEnemie && GoList[y].Otype == ObjectType.player)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.player && GoList[y].Otype == ObjectType.enemyfire)
                                    initializePlayerPosition(left, top);

                                else if (GoList[x].Otype == ObjectType.enemyfire && GoList[y].Otype == ObjectType.player)
                                    initializePlayerPosition(left, top);
                            }
                        }
                    }
                }
            }
        }

        public void update()
        {
            foreach (GameObject go in GoList)
            {
                go.gameObjectMove();
            }
        }
    }
}