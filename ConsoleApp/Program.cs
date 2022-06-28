//USING - deklaracja, że będziemy korzystać z klas wskazanej przestrzeni nazw
using ConsoleApp;

NumbersDemo numbersDemo = new NumbersDemo();
//numbersDemo.Run();





StringDemo stringDemo = new StringDemo();
//stringDemo.Run();


//Person person = new Person("Ewowska", "Ewa");
Person person = new Person("Ewa") { Age = 12, LastName = "Ewowska"}; // {} - inicjalizator pozwala na uzupełnienie właściwości po konstruktorze, ale przed uzyskaniem obiektu
System.Console.WriteLine($"{person.FirstName} {person.LastName}");

//person.FirstName = "Monika"; //nie możemy, bo setter jest prywatny
person.LastName = "Monikowska";


