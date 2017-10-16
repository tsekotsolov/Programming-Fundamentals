using System;
using System.Linq;


namespace P08_Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {

            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArray = new int[inputArray.Length - 1];

            if (inputArray.Length == 1)
            {
                Console.WriteLine(inputArray[0]);
                return;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = inputArray[j] + inputArray[j + 1];
                }
                inputArray = condensedArray;
            }
            Console.WriteLine(condensedArray[0]);

        }
    }
}


//var inputArr = Console.ReadLine().
//    Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
//    Select(int.Parse).
//    ToArray();
//var count = inputArr.Length;
//while (count > 1)
//{
//    for (int i = 0; i<count - 1; i++)
//    {
//        inputArr[i] = inputArr[i] + inputArr[i + 1];
//        Console.Write("{0}{1}", inputArr[i], i == count - 2 ? string.Empty : " ");
//    }

//    Console.WriteLine();
//    count--;
//}