using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Helper.Models
{
    internal class Actor
    {
        private string _naam;
        private int _y;
        private int _x;

        public Actor(string naam)
        {
            this._naam = naam;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}