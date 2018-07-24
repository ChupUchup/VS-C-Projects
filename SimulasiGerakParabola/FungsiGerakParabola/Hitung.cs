using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FungsiGerakParabola
{
    public class Hitung
    {
        public struct Koordinat
        {
            public double x, y;
        }

        public static double Rad(double sudut)
        {
            return ((Math.PI * sudut) / 180);
        }

        public static double Cos(double sudut)
        {
            return (Math.Cos(Rad(sudut)));
        }

        public static double Sin(double sudut)
        {
            return (Math.Sin(Rad(sudut)));
        }

        public static double v0(double sudut, double v)
        {
            return (Math.Sqrt(v0x(sudut, v) + v0y(sudut, v)));
        }

        public static double v0x(double sudut, double v)
        {
            return (Cos(sudut) * v);
        }

        public static double v0y(double sudut, double v)
        {
            return (Sin(sudut) * v);
        }

        public static double tMax(double sudut, double v, double g)
        {
            return (2 * ((Sin(sudut) * v) / g));
        }

        public static double xMax(double sudut, double v, double g)
        {
            return ((Math.Pow(v, 2) * 2 * Cos(sudut) * Sin(sudut)) / g);
        }

        public static double yMax(double sudut, double v,double g)
        {
            return ((Math.Pow(v, 2) * Math.Pow(Sin(sudut), 2)) / (2 * g));
        }

        public static double xT(double sudut, double v, double t)
        {
            return (v0x(sudut, v) * t);
        }

        public static double yT(double sudut, double v, double g, double t)
        {
            return ((v0y(sudut, v) * t) - ((g * Math.Pow(t, 2)) / 2));
        }

        public static void Koor(ref Koordinat[]xy, double sudut, double v, double g, double tick)
        {
            double t = tMax(sudut, v, g);
            int count = 0;

            for (double i = 0; i < t; )
            {
                Array.Resize(ref xy, count + 1);
                xy[count].x = xT(sudut, v, i);
                xy[count].y = yT(sudut, v, g, i);
                count += 1;
                i += tick;
                if (i >= t) xy[count - 1].y = 0;
            }
        }
    }
}
