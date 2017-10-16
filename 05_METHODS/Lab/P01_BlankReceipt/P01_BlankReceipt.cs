using System;


namespace P01_BlankReceipt
{
    class P01_BlankReceipt
    {
        static void Main()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine($"CASH RECEIPT {Environment.NewLine}" +
                $"------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine($"Charged to____________________{Environment.NewLine}" +
                $"Received by___________________ ");


        }
        static void PrintReceiptFooter()
        {
            Console.WriteLine($"------------------------------{Environment.NewLine}" +
                $"\u00A9 SoftUni");
        }

    }
}