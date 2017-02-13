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

        public MainScreen()
        {
            InitializeComponent();

            _actorenLijst = new List<Actor>();
            _usecaseLijst = new List<UseCase>();
        }

        private void PaintPanel_Click(object sender, EventArgs e)
        {
            if (ActorSwitch.Checked)
            {
                Actor newActor = new Actor("test");
                newActor.X = Cursor.Position.X;
                newActor.Y = Cursor.Position.Y;
                _actorenLijst.Add(newActor);

                MessageBox.Show("NIewe obj aangemaakt" + _actorenLijst.Count);
            }
        }
    }
}