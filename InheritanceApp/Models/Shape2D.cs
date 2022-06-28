using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public abstract class Shape2D : Shape1D
    {
        public Shape2D(string name, int width, int height) : base(name, width)
        {
            Height = height;
        }

        public int Height { get; }



        public override string ToString()
        {
            return $"{base.ToString()} i wysokości {Height}";
        }
        public override void AbstractMethod()
        {
            Console.WriteLine($"Implementacja metody abstrakcujnej w Shape2D, jestem {Name}");
        }

        public override void VirtualMethod()
        {
            Console.WriteLine("Metoda wirtualna w Shape2D");
        }
    }
}
