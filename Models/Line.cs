using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Helper.Models
{
    public class Line
    {
        private Point _beginPunt;
        private Point _eindPunt;

        public Point BeginPunt
        {
            get { return _beginPunt; }
            set { _beginPunt = value; }
        }

        public Point EindPunt
        {
            get { return _eindPunt; }
            set { _eindPunt = value; }
        }

        public bool HasBothPoints()
        {
            if (_beginPunt.Y > 0 && _beginPunt.X > 0 && _eindPunt.Y > 0 && _eindPunt.X > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}