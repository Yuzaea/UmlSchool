//string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
using ConsoleApp2;
using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string userName = Environment.UserName;

        string filePath = $@"C:\Users\{userName}\Documents\UML2.txt";
        int i = 1;
        while (i > 0)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Creating Pizza File");
                using FileStream fileStream = File.Open(filePath, FileMode.Append);
                using StreamWriter file = new StreamWriter(fileStream);
                file.WriteLine("1,Margherita,69,Tomato & Cheese,");
                file.WriteLine("2,Vesuvio,75,Tomato. cheese & ham,");
                file.WriteLine("3,Capricciosa,80,Tomato. cheese. ham & mushrooms,");
                file.WriteLine("4,Calzone,80,baked pizza with tomato. cheese. ham & mushrooms,");
                file.WriteLine("5,Quattro Stagioni,75,Tomato. cheese. ham. mushrooms. shrimp & peppers,");
                file.WriteLine("6,Marinara,85,Tomato. cheese. shrimp. mussels & garlic,");
                file.WriteLine("7,Vegetarian,80,Tomato. cheese & vegetables,");
                file.WriteLine("8,Italiana,75,Tomato. cheese. onion & meat sauce,");
                file.WriteLine("9,Gorgonzola,85,Tomato. gorgonzola. onion & mushroom,");
                file.WriteLine("10,Contadina,75,Tomato. cheese. mushroom & olvies,");
                file.WriteLine("11,Naples,79,Tomato. cheese. anchovies & olives,");
                file.WriteLine("12,Vichinga,80,Tomato. cheese. ham. mushrooms. peppers. garlic & chili(Strong),");
                file.WriteLine("13,Calzone Special,80,(not baked) tomato. cheese. shrimp. ham & meat saucce,");

                i--;
            }
            else
            {
                i--;
            }
        }


        List<Pizza> puzza = new List<Pizza>();
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            string[] entries = line.Split(",");
            Pizza newPizza = new();
            newPizza.Num = entries[0];
            newPizza.Name = entries[1];
            newPizza.Price = entries[2];
            newPizza.Ingredients = entries[3];

            puzza.Add(newPizza);

        }

        var pizzaDick = new PizzaDick();


        foreach (var pizza in puzza)
        {
            pizzaDick.AddPizza(pizza.Num, pizza);

        }

        Console.WriteLine("lookup");
        Pizza foundPizza = pizzaDick.LookupPizza("8");

        if (foundPizza != null)
        {
            //Udskriv foundpizza
            Console.WriteLine($"Pizza fundet {foundPizza.ToString()}");
        }
        else
        {
            //    //Udskriv Pizza ikke fundet
            Console.WriteLine("Pizza ikke fundet");

        }
        Console.WriteLine(puzza.ToString);
        Menu menu = new Menu(pizzaDick);
        menu.Run();
        Console.ReadLine();


    }
}