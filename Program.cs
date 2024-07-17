using StudentApp.models;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(101, "Texas", new DateTime(1990, 4, 24));
            Student student = new Student(102, "Boston", new DateTime(2003, 12, 15), "Computer");
            Professor professor = new Professor(103, "Indiana", new DateTime(1979, 1, 7), 255000);

            PrintPersonDetails(person);
            PrintPersonDetails(student);
            PrintPersonDetails(professor);
        }
            static void PrintPersonDetails(Person person)
            {
                Console.WriteLine($"=========={person.GetType().Name}==========");
                Console.WriteLine(person.PrintDetails());
            }
    }
}
