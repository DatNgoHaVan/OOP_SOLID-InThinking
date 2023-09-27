using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        // The virtual keyword is used to modify a method, property, indexer, or event declared in the base class
        //and allow it to be overridden in the derived class.
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle() { }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }
}
