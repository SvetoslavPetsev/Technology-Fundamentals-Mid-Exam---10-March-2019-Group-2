using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main()
        {
            List<string> cellsInfo = Console.ReadLine().Split("#").ToList();
            int waterForAdventure = int.Parse(Console.ReadLine());

            List<int> putOutOfFire = new List<int>();
            double efford = 0;

            for (int i = 0; i < cellsInfo.Count; i++)
            {
                List<string> currCell = cellsInfo[i].Split(" = ").ToList();

                //if (currCell.Count < 2)
                //{
                //    continue;
                //}
                
                string firePower = currCell[0];
                int cellsInFire = int.Parse(currCell[1]);

                bool chek = false;

                if (firePower == "High" && cellsInFire >= 81 && cellsInFire <= 125)
                {
                    chek = true;
                }
                else if (firePower == "Medium" && cellsInFire >= 51 && cellsInFire <= 80)
                {
                    chek = true;
                }
                else if (firePower == "Low" && cellsInFire >= 1 && cellsInFire <= 50)
                {
                    chek = true;
                }

                if (waterForAdventure - cellsInFire < 0 || chek == false)
                {
                    continue;
                }

                else if (chek)
                {
                    waterForAdventure -= cellsInFire;
                    putOutOfFire.Add(cellsInFire);
                    double currEfford = ((double)cellsInFire / 100) * 25;
                    efford += currEfford;
                }

                if (waterForAdventure == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Cells:");
            for (int i = 0; i < putOutOfFire.Count; i++)
            {
                Console.WriteLine(" - " + putOutOfFire[i]);
            }
            Console.WriteLine($"Effort: {efford:F2}");
            Console.WriteLine("Total Fire: " + putOutOfFire.Sum());
        }
    }
}
