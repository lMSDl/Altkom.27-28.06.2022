using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    //klasa abstrakcyjna - nie można utworzyć instancji tej klasy
    public abstract class Shape 
    {
        //protected - modyfikator dostępu ukrywający zmienną/właściwość/metodę przed światem zewnętrznym, jednak dostęp w hierarchi dziedziczenia pozostaje
        protected string Name { get; }

        //private - dostępne tylko dla klasy w której występuje
        private string Description { get; }

        public Shape(string name)
        {
            Name = name;
        }

        //abstrakcyjna metoda - metoda nie posiadająca ciałą, która wymaga implemenracji w klasach dziedziczących
        public abstract void AbstractMethod();
        //metoda wirtualna - metoda posiadająca implementację, ale pozwalająca się nadpisać
        public virtual void VirtualMethod()
        {
            Console.WriteLine("To jest metoda wirtualna Shape");
        }

        public void SomeMethod()
        {

        }

        //override - nadpisujemy metodę virtualną lub abstrakcyjną z klasy bazowej
        public override string ToString()
        {
            return Name;
        }
    }
}
