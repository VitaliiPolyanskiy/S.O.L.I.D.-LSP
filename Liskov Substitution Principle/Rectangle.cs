using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Rectangle: IRectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }
}
