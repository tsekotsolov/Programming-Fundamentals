using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Randomize_Words
{

    class Program
    {
        static void Main()
        {

            string[] words = Console.ReadLine().Split() ;

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {

                int swapIndexFirst = random.Next(0, words.Length);
                int swapIndexSecond = random.Next(0, words.Length);

                string oldFirst = words[swapIndexFirst];
                words[swapIndexFirst] = words[swapIndexSecond];
                words[swapIndexSecond] = oldFirst;
            }


            Console.WriteLine(string.Join(Environment.NewLine, words));
         
        }
    }
}
