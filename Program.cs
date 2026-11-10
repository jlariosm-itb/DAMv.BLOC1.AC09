using System;

public class Program
{
    public static void Main()
    {
        string[] pokemonList = { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra" };
        string opcion = "";

        while (opcion != "0")
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Llistar pokémons");
            Console.WriteLine("0- Exit");
            Console.Write("> ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("\nYour Pokédex contains:");
                for (int i = 0; i < pokemonList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {pokemonList[i]}");
                }

                Console.WriteLine("\nWhich Pokémon do you want to release? Enter the index:");
                Console.Write("> ");

                if (int.TryParse(Console.ReadLine(), out int indexUsuario))
                {
                    int indexArray = indexUsuario - 1;

                    if (indexArray >= 0 && indexArray < pokemonList.Length)
                    {
                        if (pokemonList[indexArray] == "Empty")
                        {
                            Console.WriteLine($"The index {indexUsuario} is empty. There's no Pokémon in that slot to release.");
                        }
                        else
                        {
                            Console.WriteLine($"You released {pokemonList[indexArray]}!");
                            pokemonList[indexArray] = "Empty";
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid index. Please enter a number between 1 and 15.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid number.");
                }
            }
            else if (opcion != "0")
            {
                Console.WriteLine("\nInvalid option.");
            }
        }
    }
}
