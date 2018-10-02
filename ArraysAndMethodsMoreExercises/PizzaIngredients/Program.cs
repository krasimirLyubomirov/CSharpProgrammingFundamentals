namespace PizzaIngredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            int lengthOfIngredients = int.Parse(Console.ReadLine());

            int countOfIngredient = 0;
            List<string> validIngredient = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == lengthOfIngredients)
                {
                    validIngredient.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    countOfIngredient++;
                }

                if (countOfIngredient == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {countOfIngredient} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", validIngredient)}.");
        }
    }
}
