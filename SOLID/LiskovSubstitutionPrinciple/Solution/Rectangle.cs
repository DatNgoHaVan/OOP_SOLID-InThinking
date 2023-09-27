using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_SOLID_InThinking.SOLID.LiskovSubstitutionPrinciple.Solution
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Override the Area from the base class Shape
        public override int GetArea()
        {
            return Width * Height;
        }
    }
}
