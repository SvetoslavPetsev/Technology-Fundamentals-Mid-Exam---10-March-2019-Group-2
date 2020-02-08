using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main()
        {
            List<string> someWords = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                List<string> command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]) + 1;
                    if (index >= 0 && index <= someWords.Count - 1)
                    {
                        someWords.RemoveAt(index);
                    }
                }

                else if (command[0] == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];
                    int indexCounter = 1;
                    for (int i = 0; i < someWords.Count - 1; i++)
                    {
                        string curr1 = someWords[i];
                        for (int j = indexCounter; j < someWords.Count; j++)
                        {
                            string curr2 = someWords[j];

                            if (curr1 == word1 && curr2 == word2)
                            {
                                someWords.Insert(i, word2);
                                someWords.RemoveAt(i + 1);
                                someWords.Insert(j, word1);
                                someWords.RemoveAt(j + 1);
                                indexCounter = j + 1;
                                break;
                            }

                            else if (curr1 == word2 && curr2 == word1)
                            {
                                someWords.Insert(i, word1);
                                someWords.RemoveAt(i + 1);
                                someWords.Insert(j, word2);
                                someWords.RemoveAt(j + 1);
                                indexCounter = j + 1;
                                break;
                            }
                        }
                    }
                }
                else if (command[0] == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]) - 1;

             
                    if (index >= 0 && index < someWords.Count + 1)
                    {
                        someWords.Insert(index, word);
                    }

                }
                else if (command[0] == "Sort")
                {
                    someWords = someWords.OrderByDescending(x => x).ToList();
                }
                else if (command[0] == "Replace")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    for (int i = 0; i < someWords.Count; i++)
                    {
                        string curr = someWords[i];
                        if (curr == word2)
                        {
                            someWords.Insert(i, word1);
                            someWords.RemoveAt(i + 1);
                            break;
                        }
                    }
                }
            }
            if (someWords.Count > 0)
            {
                Console.WriteLine(string.Join(" ", someWords));
            }
        }
    }
}
