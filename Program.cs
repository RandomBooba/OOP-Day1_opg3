using OOP_Day1_opg3.Referencetype;

namespace OOP_Day1_opg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Fornavn = "John",
                Efternavn = "Doe",
                Vægt = 70,
                Højde = 1.75
            };

            Console.WriteLine($"BMI for {person.Fornavn} {person.Efternavn} er: {person.BMI}");
        }
    }
}
