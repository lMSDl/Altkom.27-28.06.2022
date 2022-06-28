using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class Shape
    {
        public abstract int GetArea();
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int GetArea()
        {
            return A * B;
        }
    }

    public class Square : Rectangle
    {
        public override int A
        {
            get
            {
                return base.A;
            }
            set
            {
                base.A = base.B = value;
            }
        }

        public override int B
        {
            get
            {
                return base.B;
            }
            set
            {
                base.A = base.B = value;
            }
        }

    }

}
