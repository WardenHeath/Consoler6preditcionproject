using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace R6predictionConsoleApp
{
    class Menu
    {
        private int selectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[]options)
        {
            Prompt = prompt;
            Options = options;
            selectedIndex = 0;
        }
        public void displayOptions()
        {
            WriteLine(Prompt);
            for(int i = 0;i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if(i == selectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<< {currentOption} >>");

            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                displayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                //update based on arrow keys
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if(selectedIndex == -1)
                    {
                        selectedIndex = Options.Length - 1;
                    }
                }else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if(selectedIndex == Options.Length)
                    {
                        selectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }
    }
}
