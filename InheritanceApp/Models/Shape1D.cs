using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public abstract class Shape1D : Shape
    {
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public int Width { get; }

        public override string ToString()
        {
            return $"{base.ToString()} o szerokości {Width}";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Implementacja metody abstrakcujnej w Shape1D");
        }
    }
}
