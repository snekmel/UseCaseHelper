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
        private List<Line> _lineLijst;
        private Image _actorImage = Image.FromFile(@"C:\Users\Lars Lemkens\Desktop\UseCaseHelper\UseCaseHelper\actorImg.png");
        private Brush _brush;
        private Pen _pen;

        public List<Actor> ActorenLijst
        {
            get { return _actorenLijst; }
            set { _actorenLijst = value; }
        }

        public List<UseCase> UseCaseLijst
        {
            get { return _usecaseLijst; }
            set { _usecaseLijst = value; }
        }

        public MainScreen()
        {
            InitializeComponent();
            _actorenLijst = new List<Actor>();
            _usecaseLijst = new List<UseCase>();
            _lineLijst = new List<Line>();

            _brush = new SolidBrush(Color.DarkBlue);
            _pen = new Pen(_brush, 5);
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
                    Actor newActor = new Actor("Actornaam" + _actorenLijst.Count);

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
                    newUsecase.Naam = "Usecase" + _usecaseLijst.Count;
                    newUsecase.Pointer = pointer;
                    _usecaseLijst.Add(newUsecase);

                    //herlaad
                    PaintPanel.Invalidate();
                }

                //Maak een lijn
                else if (LineSwitch.Checked)
                {
                    //als het de eerste lijn is maak een nieuw obj
                    if (_lineLijst.Count == 0)
                    {
                        Line newLine = new Line();
                        newLine.BeginPunt = PaintPanel.PointToClient(Cursor.Position);
                        _lineLijst.Add(newLine);
                    }
                    else
                    {
                        Line lastLineInList = _lineLijst[_lineLijst.Count - 1];
                        if (!lastLineInList.HasBothPoints())
                        {
                            lastLineInList.EindPunt = PaintPanel.PointToClient(Cursor.Position);
                            _lineLijst[_lineLijst.Count - 1] = lastLineInList;
                        }
                        else
                        {
                            Line newLine = new Line();
                            newLine.BeginPunt = PaintPanel.PointToClient(Cursor.Position);
                            _lineLijst.Add(newLine);
                        }
                    }
                }

                //Herlaad het paintpanel
                PaintPanel.Invalidate();
            }

            //Edit
            else if (selectSwitch.Checked)
            {
                //Haal de geselecteerde actor op en geef door naar actorscherm
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

                //Haal de geselecteerde usecase op en geef door aan usecasescherm.
                foreach (UseCase uc in _usecaseLijst)
                {
                    if (clickPointer.Y > uc.Pointer.Y - 40 && clickPointer.Y < uc.Pointer.Y + 40)
                    {
                        if (clickPointer.X > uc.Pointer.X - 100 && clickPointer.X < uc.Pointer.X + 100)
                        {
                            UsecaseScherm niewScherm = new UsecaseScherm(uc, this);
                            niewScherm.Show();
                        }
                    }
                }
            }
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
                Point drawPointer = uc.Pointer;

                //Positioneer de ellipse op de click
                drawPointer.X = drawPointer.X - 110;
                drawPointer.Y = drawPointer.Y - 175;

                e.Graphics.DrawEllipse(_pen, drawPointer.X, drawPointer.Y, 200, 100);

                //Positioneer pointer voor tekst
                Point textPointer = drawPointer;
                textPointer.Y = drawPointer.Y + 40;
                textPointer.X = drawPointer.X + 70;

                // teken tekst
                e.Graphics.DrawString(uc.Naam, this.Font, _brush, textPointer);
            }

            foreach (Line lijn in _lineLijst)
            {
                if (lijn.HasBothPoints())
                {
                    e.Graphics.DrawLine(_pen, lijn.BeginPunt, lijn.EindPunt);
                }
            }
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawObjects(e);
        }

        public void Repaint()
        {
            //Herlaad het paintpanel
            PaintPanel.Invalidate();
        }
    }
}