using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main()
        {
            int daysAdventure = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());

            double WaterPerDayForOne = double.Parse(Console.ReadLine());
            double foodPerDayForOne = double.Parse(Console.ReadLine());

            double waterRequared = WaterPerDayForOne * numberOfPlayers * daysAdventure;
            double foodRequared = foodPerDayForOne * numberOfPlayers * daysAdventure;

            for (int i = 1; i <= daysAdventure; i++)
            {

                double loseEnergy = double.Parse(Console.ReadLine());

                groupEnergy -= loseEnergy;

                if (groupEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    waterRequared -= (waterRequared / 100) * 30;
                    groupEnergy += (groupEnergy / 100) * 5;
                }

                if (i % 3 == 0)
                {
                    foodRequared -= foodRequared / numberOfPlayers;
                    groupEnergy += (groupEnergy / 100) * 10;
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodRequared:F2} food and {waterRequared:F2} water.");
            }
        }
    }
}
