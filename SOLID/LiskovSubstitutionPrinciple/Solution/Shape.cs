using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_SOLID_InThinking.SOLID.LiskovSubstitutionPrinciple.Solution
{
    // Make an abstract class for Shape
    // Every shape has its own Area
    public abstract class Shape
    {
        public abstract int GetArea();
    }
}
