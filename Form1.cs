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
                    MessageBox.Show(pointer.ToString());

                    //Geef de positie
                    newActor.X = pointer.X - 25;
                    newActor.Y = pointer.Y - 170;

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
                }
            }

            //Edit
            else if (selectSwitch.Checked)
            {
                Point clickPointer = PointToClient(Cursor.Position);

                foreach (Actor actor in _actorenLijst)
                {
                    if (clickPointer.Y < actor.Y + 130 && clickPointer.Y > actor.Y - 100)
                    {
                    }
                }
            }
        }

        private void DrawObjects(PaintEventArgs e)
        {
            foreach (Actor a in _actorenLijst)
            {
                //Teken actor poppetje
                e.Graphics.DrawImage(_actorImage, new Point((a.X), (a.Y)));

                //Locatie van de tekst
                Point textPointer = new Point((a.X), (a.Y + 130));

                //Teken de tekst
                e.Graphics.DrawString(a.Naam, this.Font, _brush, textPointer);
            }
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawObjects(e);
        }
    }
}