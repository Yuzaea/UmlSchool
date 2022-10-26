using ConsoleApp2;
using static ConsoleApp2.PizzaDick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp2
{ 
public class Menu
{

    private PizzaDick _pizzaDick;
        public Menu(PizzaDick pizzaDick)
        {

            _pizzaDick = pizzaDick;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }
            public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t1.\tBestil pizza");
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }
        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        //ToDO
                        Console.Clear();
                        Console.WriteLine("Hello");

                        break;
                    case 7:
                        {
                            {

                                Console.WriteLine("\t1.\tTilføj Pizza til PizzaDick");
                                Console.WriteLine("\t2.\tUdskriv alle Piza fra PizzaDick");
                                Console.WriteLine("\t3.\tSøg efter en Pizza i PizzaDick udfra Nummer");
                                Console.WriteLine("\t4.\tFjern Pizza i PizzaDick");
                                Console.WriteLine("\t5.\tOpdater Pizza fra PizzaDick");
                                int AdminValg = int.Parse(Console.ReadLine());
                                while (AdminValg != 0)
                                {
                                    switch (AdminValg)
                                    {
                                        case 1:
                                            Console.Clear();
                                            AddPizzaToDick();
                                            break;
                                        case 2:
                                            Console.Clear();
                                            _pizzaDick.PrintPizza();
                                            break;
                                        case 3:
                                            Console.Clear();
                                            LookUpPizzaDick();
                                            break;
                                        case 4:
                                            Console.Clear();
                                            DeletePizzaFromDick();
                                            break;
                                        case 5:
                                            Console.Clear();
                                            UpdatePizzaDick();
                                                break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Fejl i input");
                                            break;


                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }


                            }
                            break;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();

            }

        }



        private void AddPizzaToDick()
        {
            Console.WriteLine("Add Pizza");
            Console.WriteLine("Angiv num");
            string num = Console.ReadLine();
            Console.WriteLine("Angiv Navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv Pris");
            string price = Console.ReadLine();
            Console.WriteLine("Angiv hvilke Ingredienser");
            string ingredients = Console.ReadLine();
            Pizza b = new Pizza(num, name, price, ingredients);
            _pizzaDick.AddPizza(num, b);
            string userName = Environment.UserName;
            string filePath = $@"C:\Users\{userName}\Documents\UML2.txt";
            List<Pizza> puzza = new List<Pizza>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            lines.Add($"{num}, {name}, {price}, {ingredients}");
            File.WriteAllLines(filePath, lines);
        }
        private void DeletePizzaFromDick()
        {
            Console.WriteLine("Delete Pizza");
            Console.WriteLine("Angiv Num");
            string NumOld = Console.ReadLine();
            Pizza puzza = _pizzaDick.LookupPizza(NumOld);
            string userName = Environment.UserName;
            string text = File.ReadAllText($@"C:\Users\{userName}\Documents\UML2.txt");
            string Old = (puzza.ToString());

            Console.WriteLine(Old);
            text = text.Replace($"{Old}", null);
            File.WriteAllText($@"C:\Users\{userName}\Documents\UML2.txt", text);

        }

        private void LookUpPizzaDick()
        {
            Console.WriteLine("Search Pizza");
            Console.WriteLine("Angiv Num");
            string num = Console.ReadLine();
            Pizza puzza = _pizzaDick.LookupPizza(num);
            if (puzza == null)
            {
                Console.WriteLine("Pizzaen der søges efter eksisterer ikke");
            }
            else
            {
                Console.WriteLine(puzza);
            }
            Console.ReadLine();
        }

        private void UpdatePizzaDick()
        {
            Console.WriteLine("Update Pizza");
            Console.WriteLine("Angiv Num på Pizzaen der skal opdateres");
            string NumOld = Console.ReadLine();
            Pizza puzza = _pizzaDick.LookupPizza(NumOld);
            if (puzza == null)
            {
                Console.WriteLine("pizzaen der søges efter eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Update Pizza");
                Console.WriteLine("Angiv Num");
                string num = Console.ReadLine();
                Console.WriteLine("Angiv Name");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv Price");
                string price = Console.ReadLine();
                Console.WriteLine("Angiv ingredienser");
                string ingredients = Console.ReadLine();

                Pizza updatedPizza = new Pizza(num, name, price, ingredients);
                string Old = (puzza.ToString());
                string userName = Environment.UserName;
                Console.WriteLine(updatedPizza);
                Console.WriteLine(Old);
                string text = File.ReadAllText($@"C:\Users\{userName}\Documents\UML2.txt");
                text = text.Replace($"{Old}", $"{updatedPizza}");
                File.WriteAllText($@"C:\Users\{userName}\Documents\UML2.txt", text);

                Console.WriteLine("Pizzaen er opdateret");
            }
         



            }
        }

    }
