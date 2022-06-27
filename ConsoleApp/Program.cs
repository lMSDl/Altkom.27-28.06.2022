//USING - deklaracja, że będziemy korzystać z klas wskazanej przestrzeni nazw
using ConsoleApp;


StringDemo stringDemo = new StringDemo();
stringDemo.Run();


Person person = new Person("Ewowska", "Ewa");
Console.WriteLine($"{person.FirstName} {person.LastName}");

//person.FirstName = "Monika"; //nie możemy, bo setter jest prywatny
person.LastName = "Monikowska";