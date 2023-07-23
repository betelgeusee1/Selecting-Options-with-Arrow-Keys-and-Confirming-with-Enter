using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YonTuslariDeneme
{


    class Program
    {
        static void Main()
        {
            string[] menuOptions = { "Option 1", "Option 2", "Option 3", "Exit" };
            int selectedOption = 0;

            Console.CursorVisible = false;

            while (true)
            {
                // Menüyü ekrana yazdırma
                Console.Clear();
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("-> ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.WriteLine(menuOptions[i]);
                    Console.ResetColor();
                }

                // Yön tuşlarıyla seçenekleri seçme
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedOption > 0)
                            selectedOption--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (selectedOption < menuOptions.Length - 1)
                            selectedOption++;
                        break;

                    case ConsoleKey.Enter:
                        if (selectedOption == menuOptions.Length - 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Logged out.");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Selected option: {menuOptions[selectedOption]}");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
