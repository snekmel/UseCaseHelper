using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Helper.Models;

namespace UC_Helper
{
    public partial class MainScreen : Form
    {
        private List<Actor> _actorenLijst;
        private List<UseCase> _usecaseLijst;
        private Image _actorImage = Image.FromFile(@"C:\Users\Lars Lemkens\Desktop\UseCaseHelper\UseCaseHelper\actorImg.png");
        private Brush _brush;

        public MainScreen()
        {
            InitializeComponent();
            _actorenLijst = new List<Actor>();
            _usecaseLijst = new List<UseCase>();
            _brush = new SolidBrush(Color.DarkBlue);
        }

        private void PaintPanel_Click(object sender, EventArgs e)
        {
            //Create
            if (createSwitch.Checked)
            {
                //Create actor:
                if (ActorSwitch.Checked)
                {
                    //Maak een nieuwe actor aan
                    Actor newActor = new Actor("Actornaam");

                    Point pointer = PointToClient(Cursor.Position);
                    newActor.Pointer = pointer;

                    //Voeg toe aan de lijst.
                    _actorenLijst.Add(newActor);

                    //Herlaad het paintpanel
                    PaintPanel.Invalidate();
                }

                //Create usecase:
                else if (UseCaseSwitch.Checked)
                {
                    //Maak een nieuw usecase obj
                    UseCase newUsecase = new UseCase();
                    Point pointer = PointToClient(Cursor.Position);
                    newUsecase.Naam = "newUecase";
                    newUsecase.Pointer = pointer;
                    _usecaseLijst.Add(newUsecase);
                }
            }

            //Edit
            else if (selectSwitch.Checked)
            {
                Point clickPointer = PointToClient(Cursor.Position);

                foreach (Actor actor in _actorenLijst)
                {
                    if (clickPointer.Y > actor.Pointer.Y - 72 && clickPointer.Y < actor.Pointer.Y + 68)
                    {
                        if (clickPointer.X > actor.Pointer.X - 20 && clickPointer.X < actor.Pointer.X + 31)
                        {
                            ActorScherm niewScherm = new ActorScherm(actor, this);
                            niewScherm.Show();
                        }
                    }
                }

                foreach (UseCase uc in _usecaseLijst)
                {
                    MessageBox.Show(uc.Naam);
                }
            }

            //Herlaad het paintpanel
            PaintPanel.Invalidate();
        }

        private void DrawObjects(PaintEventArgs e)
        {
            foreach (Actor a in _actorenLijst)
            {
                //Teken actor poppetje
                Point newPointer = a.Pointer;
                newPointer.X = newPointer.X - 35;
                newPointer.Y = newPointer.Y - 200;

                e.Graphics.DrawImage(_actorImage, newPointer);

                //Locatie van de tekst
                Point textPointer = newPointer;
                textPointer.Y = newPointer.Y + 130;

                //Teken de tekst
                e.Graphics.DrawString(a.Naam, this.Font, _brush, textPointer);
            }

            foreach (UseCase uc in _usecaseLijst)
            {
                //TODO: Teken elips hier
            }
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawObjects(e);
        }

        public List<Actor> ActorenLijst
        {
            get { return _actorenLijst; }
            set { _actorenLijst = value; }
        }

        public void Repaint()
        {
            //Herlaad het paintpanel
            PaintPanel.Invalidate();
        }
    }
}