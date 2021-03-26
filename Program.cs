using System;
using System.Diagnostics;
namespace R6predictionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to choose a option: ");
            Menu();

        }
        //CSV structure is as follows:
        //name,Player,Rating,K,D,OK,OD,Kost,KPR,SRV,1vx,Plants,hs(%),atk,def,teamnumber,result,map
        //when entering for win loss prediction
        //K,D,KPR,SRV,Result,Map
        //when entering for KOST prediction
        //K,D,KPR,SRV,Result,Map
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Win predection with basic stats");
            Console.WriteLine("2. Kost predection");
            Console.WriteLine("3. Menu");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter: ");
            int UserChoice = int.Parse(Console.ReadLine());
            if (UserChoice == 1)
            {
                Console.Clear();

                Console.WriteLine("\nLaunching Win prediction...");
                winPrediction();

            } else if (UserChoice == 2) { 
                
                Console.WriteLine("\nLaunching Kost prediction...");
                KostPrediction();
                
            }
            else if (UserChoice == 3)
            {
                Menu();
            }else if (UserChoice == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Menu();
            }
        }

        private static void winPrediction()
        {

            //wait for exit is crucial to keep the menu from breaking 
            Process.Start("C:\\prediction\\WinPrediction\\Winprediction.exe").WaitForExit();
            Console.WriteLine("\nPress anything to return to menu");
            Console.ReadKey();
            Menu();
        }

        private static void KostPrediction()
        {
            Process.Start("C:\\prediction\\KostPrediction\\Kostprediction.exe").WaitForExit();
            Console.WriteLine("\nPress anything to return to menu"); 
            Console.ReadKey();
            Menu();
        }
    }
}
