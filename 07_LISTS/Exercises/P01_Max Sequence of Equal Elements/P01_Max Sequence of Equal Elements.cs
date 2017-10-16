using System;
using System.Collections.Generic;
using System.Linq;


namespace P01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
       
            var myList = Console.ReadLine()
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .ToList();

            int longestSeqLength = 1;
            int longestSeqStart = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;

            for (int i = 1; i < myList.Count; i++)
            {
                if (myList[i] == myList[i - 1])
                {
                    currentSeqLength++;

                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }

            for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
    }

