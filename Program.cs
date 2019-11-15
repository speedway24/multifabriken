using System;
using System.Collections.Generic;
namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Create list
            var list = new List<string>();
            // Så länge go is true så körs programmet
            var go = true;
            var menu = new menu();
            
            //menu 
            while (go)
            {
                // menu from file menu.cs
                menu.myMenu();
                
                // userInput läser in vilket menyval som görs
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {

                    case 1:
                        Console.WriteLine("Reg nummmer?");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Färg?");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Bilmärke?");
                        list.Add(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Vilken smak?");
                        list.Add(Console.ReadLine());
                        System.Console.WriteLine("Antal?");
                        list.Add(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Diameter?");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Längd?");
                        list.Add(Console.ReadLine());
                        break;
                    
                     case 4:
                        Console.WriteLine("Fetthalt?");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Litermängd?");
                        list.Add(Console.ReadLine());
                        break;


                    case 5:
                        Console.WriteLine("Du har valt:");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        // för att menyn inte ska visas direkt
                        Console.WriteLine("Tryck på enter för att komma till menyn");
                        Console.ReadLine();
                        
                        break;
                    case 6:
                        // exit loop and program
                        go = false;
                        break;
                }
            }
        } //while loop ends
    }
}
