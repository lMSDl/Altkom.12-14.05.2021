using System;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Memento
{
    public static class Client
    {
        public static void Execute()
        {
            Person person = new Person
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1992, 1, 23)
            };


            using (Caretaker<Person> caretaker = new Caretaker<Person>(person))
            {

                Console.WriteLine(person.Name);

                person.Name = "Ewa Adamska";
                Console.WriteLine(person.Name);
                //caretaker.SaveSate();

                person.Name = "Ewa Ewowska";
                Console.WriteLine(person.Name);
                //caretaker.SaveSate();

                person.Name = "Ewa";
                Console.WriteLine(person.Name);

                caretaker.RestoreBeginState();
                Console.WriteLine(person.Name);
                caretaker.Undo();
                Console.WriteLine(person.Name);
                caretaker.Undo();
                Console.WriteLine(person.Name);
            }

        }
    }
}
