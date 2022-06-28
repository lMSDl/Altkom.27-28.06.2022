using Services;
using Models;

IPeopleService peopleService = new PeopleService();

//var - niejawne określenie typu, typ jest określany na podstawie prawej strony znaku =.
var people = peopleService.GetPeople();
bool exit = false;

//pętla while  - działa gdy warunek jest spełniony (true)
//! - negacja
//while (!exit)

//pętla do-while - sprawdza warunek na końcu = co najmniej raz ciało pętli zostanie wykonane
do
{
    Console.Clear();

    //pętla foreach - przechodzi po każdym elemencie listy
    foreach (var person in people)
    {
        var line = $"{person.Id}\t{person.LastName}\t{person.FirstName}\t{person.Age}";
        Console.WriteLine(line);
    }

    ShowMenu();
    var input = PeopleService.GetData("Wybierz co chcesz zrobić:");

    //instrukcja warunkowa if - else if - else
    //= - przypisanie
    //== - porównanie
    //if (input == "1")
    //{
    //    peopleService.Create();
    //}
    //else if (input == "2")
    //{
    //    var id = AskForId();
    //    peopleService.Update(id);
    //}
    //else if (input == "3")
    //{
    //    var id = AskForId();
    //    peopleService.Delete(id);
    //}
    //else if(input == "4")
    //{
    //    exit = true;
    //}
    //else
    //{
    //    Console.WriteLine("Błędna opcja");
    //}

    //switch - przełącza nas do bloku kodu, którego case pasuje do parametry wejściowego (input)
    switch (input)
    {
        case "1":
        case "dodaj":
        case "add":
            peopleService.Create();
            break;
        case "2":
            {
            var id = AskForId();
            peopleService.Update(id);
            }
            break;
        case "3":
            {
            var id = AskForId();
            peopleService.Delete(id);
            }
            break;
        case "4":
            exit = true;
            break;
            //default - wykonuje się gdy nie dopasowane case
        default:
            Console.WriteLine("Błędna opcja");
            break;
    }
} while (!exit);

void ShowMenu()
{
    Console.WriteLine("1. Dodaj");
    Console.WriteLine("2. Modyfikuj");
    Console.WriteLine("3. Usuń");
    Console.WriteLine("4. Koniec");
}

int AskForId()
{
    Console.WriteLine("Podaj id:");
    var input = Console.ReadLine();

    try
    {
        //rzudanie wyjątku
        //throw new Exception("Jakiś tam błąd");
        var id = int.Parse(input);
        return id;
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        return AskForId();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return 0;
    }
}