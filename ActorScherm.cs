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
    public partial class ActorScherm : Form
    {
        private Actor _a;
        private MainScreen _m;

        public ActorScherm(Actor a, MainScreen m)
        {
            InitializeComponent();
            this._a = a;
            this._m = m;
            naamTb.Text = _a.Naam;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _a.Naam = naamTb.Text;
            foreach (Actor act in _m.ActorenLijst)
            {
                if (act.Pointer == _a.Pointer)
                {
                    act.Naam = _a.Naam;
                }
            }
            _m.Repaint();
        }
    }
}