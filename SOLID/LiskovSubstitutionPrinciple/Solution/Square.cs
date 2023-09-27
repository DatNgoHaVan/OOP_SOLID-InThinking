using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_SOLID_InThinking.SOLID.LiskovSubstitutionPrinciple.Solution
{
    public class Square : Shape
    {
        public int SideLength { get; set; }

        // Override the Area from the base class Shape
        public override int GetArea()
        {
            return SideLength ^ 2;
        }
    }
}
