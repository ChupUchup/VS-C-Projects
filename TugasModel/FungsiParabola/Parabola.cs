using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FungsiParabola
{
    public class Parabola
    {
        public static double Rad(double a)
        {
            return Math.PI * a / 180;
        }

        public static double mySin(double a)
        {
            return Math.Sin(Rad(a));
        }

        public static double myCos(double a)
        {
            return Math.Cos(Rad(a));
        }
    }
}
