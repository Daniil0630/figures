using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class GeometricFigure
    {
        public int[] CenterCoordinates = new int[2];
        public string Color;
        public int Thickness;
        Random rnd = new Random();
        public int[] RandColor = new int[3];
        public void ChangeColor()
        {
            RandColor[0] = rnd.Next(256);
            RandColor[1] = rnd.Next(256);
            RandColor[2] = rnd.Next(256);
        }
    }
    class Rectangle : GeometricFigure
    {
        public int WidthRectangle;
        public int HeightRectangle;
        Random rnd = new Random();
        public void PaintRectangle()
        {   
            WidthRectangle = rnd.Next(50, 200);
            HeightRectangle = rnd.Next(50, 200);
            CenterCoordinates[0] = rnd.Next(WidthRectangle / 2, 1300 - WidthRectangle / 2);
            CenterCoordinates[1] = rnd.Next(HeightRectangle / 2, 790 - HeightRectangle / 2);
        }
        public int SquareRectangle()
        {
            int Square = WidthRectangle * HeightRectangle;
            return Square;
        }
        public bool TestOwnRectangle(int X, int Y)
        {
            if (X >= CenterCoordinates[0] - WidthRectangle / 2 && X <= CenterCoordinates[0] + WidthRectangle / 2)
            {
                if(Y >= CenterCoordinates[1] - HeightRectangle / 2 && Y <= CenterCoordinates[1] + HeightRectangle / 2)
                    return true;
            }
            return false;
        }

    }

    class Circle : GeometricFigure
    {
        public int RadiusCircle;
        Random rnd = new Random();
        public void PaintCircle()
        {
            RadiusCircle = rnd.Next(25, 100);
            CenterCoordinates[0] = rnd.Next(RadiusCircle, 1300 - RadiusCircle);
            CenterCoordinates[1] = rnd.Next(RadiusCircle, 790 - RadiusCircle);
        }
        public double SquareCircle()
        {
            double Square = Math.PI * RadiusCircle * RadiusCircle;
            return Square;
        }
        public bool TestOwnCircle(int X, int Y)
        {
            if (X >= CenterCoordinates[0] - RadiusCircle && X <= CenterCoordinates[0] + RadiusCircle / 2)
            {
                if (Y >= CenterCoordinates[1] - RadiusCircle && Y <= CenterCoordinates[1] + RadiusCircle / 2)
                    return true;
            }
            return false;
        }
    }
}
