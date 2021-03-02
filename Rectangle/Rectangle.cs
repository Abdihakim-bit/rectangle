using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = this.width = 1;
        }
        public Rectangle(int lenght, int width)
        {
            this.length = lenght;
            this.width = width;
        }
        public int GetLength() 
        {
            return length;
        }
        public void SetLength(int length) 
        {
            this.length = length;
        }
        public int GetWidth() 
        {
            return width;
        }
        public void SetWidth(int width) 
        {
            this.width = width;
        }
        public int GetPerimeter()
        {
            return (2 * length) + (2 * width);
        }
        public int GetArea()
        {
            return length * width;
        }

    }
}
