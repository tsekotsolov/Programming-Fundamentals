using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_HornetAssault
{
    class P03_HornetAssault
    {
        static void Main(string[] args)
        {
            string s = "ivan";

            


            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            var reversed =  new string(arr);
        }
    }
}
