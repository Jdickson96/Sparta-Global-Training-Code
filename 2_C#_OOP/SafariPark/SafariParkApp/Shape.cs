using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Shape
    {
        public abstract int CalculateArea();

        public override string ToString()
        {
            return $"{this.GetType()} and the area is {this.CalculateArea()}";
        }
    }

    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public override int CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
