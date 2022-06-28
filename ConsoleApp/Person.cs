namespace ConsoleApp
{
    public class Person
    {
        public Person(int age)
        {
            Age = age;
        }
        public Person(string lastName, string firstName, int age) : this(lastName, firstName)
        {
            Age = age;
        }
        public Person(string lastName, string firstName) : this(firstName)
        {
            LastName = lastName;
        }
        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public string LastName { get; set; }
        public string FirstName { get; }
        public int Age { get; set; }
    }
}
