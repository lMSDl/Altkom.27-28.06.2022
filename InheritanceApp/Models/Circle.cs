using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Circle : Shape2D
    {
        public Circle(int r) : base("Koło", 2 * r, 2 * r)
        {
            R = r;
        }

        public int R { get; }
    }
}
