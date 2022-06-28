using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    //klasa implementuje interfejs IPeopleService
    public class PeopleService : IPeopleService
    {
        private ICollection<Person> people;

        public PeopleService()
        {
            people = new List<Person>();
        }


        public void Create()
        {
            var person = new Person();
            person.FirstName  = GetData("Imię:");
            person.LastName = GetData("Nazwisko:");
            var ageString = GetData("Wiek:");
            person.Age = int.Parse(ageString);
        
            person.Id = GenerateId();

            people.Add(person);
        }

        public void Delete(int id)
        {
        }

        public IEnumerable<Person> GetPeople()
        {
            return people;
        }

        public Person GetPerson(int id)
        {
            return null;
        }

        public void Update(int id)
        {
        }



        private int GenerateId()
        {
            int id = 0;
            foreach(var person in people)
            {
                //if(person.Id > id)
                //{
                //    id = person.Id;
                //}
                id = Math.Max(id, person.Id);
            }

            return id + 1;
        }

        private string GetData(string label)
        {
            Console.WriteLine(label);
            return Console.ReadLine();
        }
    }
}
