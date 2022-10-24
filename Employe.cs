using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_Lessons_9_protected_figure
{
    public class Employe
    {
        protected double _area;
        protected double _perimeter;
        protected string _figure;

        public Employe ()
        {
            _area = 10;
            _perimeter = 10;
            _figure = "??";
        }
        public Employe (double area, double perimetr, string figure)
        {
            this._area = area;
            this._perimeter = perimetr;
            this._figure = figure;
        }
       public void Print ()
        {
            Console.WriteLine ("\tполощадь\t" + _area + "\tпериметр\t" +
                _perimeter + "\tимя фигуры\t" + _figure + "\n");
        }
           
    }
}
