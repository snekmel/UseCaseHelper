using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Helper.Models
{
    public class Actor
    {
        private string _naam;
        private Point _pointer;

        public Point Pointer
        {
            get { return _pointer; }
            set { _pointer = value; }
        }

        public Actor(string naam)
        {
            this._naam = naam;
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}