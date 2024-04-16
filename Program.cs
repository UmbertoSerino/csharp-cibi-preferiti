namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myFood = { "Pizza", "Carbonara", "Bolognese", "Amatriciana", "Gateau di patate" };
            int totalElement = myFood.Length;
            Console.WriteLine($"La mia classifica è composta da {totalElement} elementi");
            for (int i = 0; i < myFood.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {myFood[i]}");
            }
            Console.WriteLine($"Il mio piatto preferito è {myFood[0]}");
            Console.WriteLine($"Quello che mi piace meno è {myFood[4]}");
            int half = myFood.Length / 2;
            if (myFood.Length % 2 == 0)
            {
                Console.WriteLine($"I miei due cibi sono {myFood[half - 1]} e {myFood[half]}");
            }
            else
            {
                Console.WriteLine($"A metà classifica si trova {myFood[half]}");
            }
        }
    }
}