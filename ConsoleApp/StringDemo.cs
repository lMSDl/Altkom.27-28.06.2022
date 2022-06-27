using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StringDemo
    {
        public void Run()
        {
            //deklaracja zmiennej
            string greetings;
            //inicjalizację zmiennej
            greetings = "Hello, World!";
            //przypisanie wartości
            greetings = "Hello, Paweł!";

            Console.WriteLine(greetings);

            //deklarację + inicjalizacja
            string question = "Jak się masz?";

            string message = greetings + " " + question;

            //message = string.Format("{0} {1}", greetings, question);

            //string interpolowany
            message = $"{greetings} {question}";

            Console.WriteLine(message);


            string userName = AskForData("Podaj imię:");
            string userAge = AskForData("Podaj wiek:");
            Console.WriteLine($"Info o użytkowniku: {userName} ({userAge})");

            SayGoodbye(userName);

            //budowa metody
            //<typ zwracany> <nazwa metody>(<typ opcjonalnego parametru> <nazwa opcjonalnego parametru>)
            string AskForData(string message)
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();

                //zwracamy rezultat z funkcji
                return userInput;
            }
            //string AskForData()
            //{
            //    Console.WriteLine("Podaj imię:");
            //    string userInput = Console.ReadLine();

            //    return userInput;
            //}

            //void - funkcja nic nie zwraca
            void SayGoodbye(string name)
            {
                Console.WriteLine($"Bye {name}!");
            }

        }
    }
}
