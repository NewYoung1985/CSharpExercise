using System;
using System.Collections;
using System.Linq;

using System.Collections.Generic;

namespace MacExercise
{
    class MainClass
    {



        public static void Main(string[] args)
        {
            
            int[] aaa = { 1, 2, 3, 4, 5 };

            ArrayList bbb = new ArrayList();

            foreach (int a in aaa)
            {
                bbb.Add(a);
            }

            foreach (int c in bbb)
            {

                Console.WriteLine(c);
            }

            List<int> k = new List<int>();



        }
    }

}
