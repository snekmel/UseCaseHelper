using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Helper.Models
{
    internal class UseCase
    {
        private string _naam;
        private string _samenvatting;
        private List<string> _actoren;
        private string _aannamen;
        private string _beschrijving;
        private string _uitzonderingen;
        private string _resultaat;
        private int _y;
        private int _x;

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

        public string Resultaat
        {
            get { return _resultaat; }
            set { _resultaat = value; }
        }

        public string Uitzondering
        {
            get { return _uitzonderingen; }
            set { _uitzonderingen = value; }
        }

        public string Beschrijving
        {
            get { return _beschrijving; }
            set { _beschrijving = value; }
        }

        public string Aannamen
        {
            get { return _aannamen; }
            set { _aannamen = value; }
        }

        public string Samenvatting
        {
            get { return _samenvatting; }
            set { _samenvatting = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
    }
}