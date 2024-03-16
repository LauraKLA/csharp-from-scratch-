using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dataConverted = new DateOnly();
            string nameInput;
            string birtDayInput;
            Console.WriteLine("¡Bienvenido al calculador de años!");
            Console.WriteLine("Escriba su nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"¡Un gusto conocerte {nameInput}!");
            Console.WriteLine("Escriba su fecha de nacimiento en formato dd/mm/aa: ");
            birtDayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birtDayInput, out dataConverted);
            if(isDateValid == false) 
            Console.WriteLine($"La fecha de nacimiento es invalida, usted envia el siguiente dato erroneo: {birtDayInput}");
            var person = new person
            {
                Name = nameInput,
                BirtDay = dataConverted,
                Age = DateTime.Now.Year - dataConverted.Year
            };

             Console.WriteLine($"Su nombre es: {person.Name}");
             Console.WriteLine($"Su fecha de nacimiento es: {person.BirtDay}");
             Console.WriteLine($"Su edad es: {person.Age} años");
             


            Console.WriteLine();
        }
    }

    public class person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly BirtDay { get; set; }
    }
}