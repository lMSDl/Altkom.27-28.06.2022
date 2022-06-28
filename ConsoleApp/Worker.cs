global using ConsoleApp.Demo;

namespace ConsoleApp
{
    internal class Worker
    {
        public string UserName { get; set; }


        public void Work()
        {
            UserName = AskData("Jak masz na imię?");
            string zdanie = AskData($"Cześć {UserName}! Co chcesz zrobić?");
            Console.WriteLine($"W takim razie powodzenia w {zdanie}!");
            SayGoodbye();
        }

        public string AskData(string message)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                return input;
            }

        public void SayGoodbye()
            {
                Console.WriteLine($"Do zobaczenia {UserName}!");
            }
        

    }
}
