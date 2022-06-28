using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//przestrzeń nazw - jest to pewnego rodzaju adres pod którym mieszkają klasy
namespace ConsoleApp.Demo
{
    //KLASA - opisuje zachowania i właściwości obiektów (instancji klas), które na jej podstawie są wytwarzane
    //Pełna nazwa klasy to namespace + nazwa klasy
    public class SomeClass
    {
        //właściwość
        public object SomeAutoProperty { get; set; }

        
        //backfiled - pole z którego korzysta właściwość
        private object someFullProperty;
        //właściwość z polem zapasowym (backfield)
        public object SomeFullProperty
        {
            //getter dla property
            get 
            { 
                return someFullProperty;
            }
            //setter dla property
            //setter zawsze przyjmuje pojedynczy parametr o typie zgodnym z typem property i nazywa się "value"
            set
            {
                someFullProperty = value; //value - patemetr przjmowany przez setter
            }
        }

        //private - modyfikator dostępu ograniczający dostęp do pola/metody tylko dla klasy
        //brak modyfikatora dostępu = private
        //pole
        private object someFiled;

        //public - modyfikator dostępu otwierający dostęp do pola/metody dla wszystkich
        public object GetSomeFiled()
        {
            return someFiled;
        }

        //public void SetSomeField(object value)
        //{
        //    someFiled = value;
        //}



        //konstruktor - metoda pozwalająca na utworzenie nowej instancji danej klasy / nowego obiektu
        //konstruktor z parametrem 
        public SomeClass(string param)
        {
            someFiled = param;
        }
        //konstruktor bez parametru
        public SomeClass()
        {

        }
        //Jeśli konstruktor nie został jawnie utworzony, to zostanie wygenerowany domyślny konstruktor bezparametrowy



        #region Metody
        //metoda SomeMethod została przeciążona, ponieważ wiele metod różniących się parametrami współdzieli tę samą nazwę
        public object SomeMethod(object someParameter, object anotherParameter)
        {
            return someParameter;
        }
        public object SomeMethod(object someParameter)
        {
            return someParameter;
        }
        public object SomeMethod()
        {
            //tworzymy nową instancję klasy object
            return new SomeClass();
        }

        public void AnotherMethod()
        {
            someFiled = "object";
        } 
        #endregion
    }
}
