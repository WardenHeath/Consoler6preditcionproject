using System;
using System.Diagnostics;
using static System.Console;
namespace R6predictionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "R6 Prediction";
            RunMainMenu();



        }
        static public void RunMainMenu()
        {
            string prompt = "Use arrowkeys to select and enter to choose an option....";
            string[] options = { "Win prediction", "KOST prediction", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int SelectedIndex = mainMenu.Run();

            if (SelectedIndex == 0)
            {
                Clear();
                WriteLine("\nLaunching Win prediction...");
                winPrediction();
            }
            else if (SelectedIndex == 1)
            {
                Clear();
                WriteLine("\nLaunching Kost prediction...");
                KostPrediction();

            }
            else if (SelectedIndex == 2)
            {
                Clear();
                WriteLine(@"Nothing here yet...
 Press anything to return to menu...");
                ReadKey(true);
                RunMainMenu();
            }
            else if (SelectedIndex == 3)
            {
                Environment.Exit(0);
            }
        }
        //CSV structure is as follows:
        //name,Player,Rating,K,D,OK,OD,Kost,KPR,SRV,1vx,Plants,hs(%),atk,def,teamnumber,result,map
        //when entering for win loss prediction
        //K,D,KPR,SRV,Result,Map
        //when entering for KOST prediction
        //K,D,KPR,SRV,Result,Map

        private static void winPrediction()
        {

            //wait for exit is crucial to keep the menu from breaking 
            Process.Start("C:\\prediction\\WinPrediction\\Winprediction.exe").WaitForExit();
            Console.WriteLine("\nPress anything to return to menu");
            Console.ReadKey();
            RunMainMenu();
        }

        private static void KostPrediction()
        {
            Process.Start("C:\\prediction\\KostPrediction\\Kostprediction.exe").WaitForExit();
            Console.WriteLine("\nPress anything to return to menu"); 
            Console.ReadKey();
            RunMainMenu();
        }
    }
}
