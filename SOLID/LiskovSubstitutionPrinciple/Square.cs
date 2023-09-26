using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        // From here the LSP was violated!!!
        // Class Square are trying to change the behavior of the Rectangle:
        // Specifically, modifying the Width or Height property of a Square instance affects both dimensions,
        // which contradicts the behavior of a regular Rectangle.
        public override int Width
        {
            get => base.Width;
            // Both Width and Height or equal, so they need to change when one of them changed.
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
