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

            IndexClass aaa = new IndexClass(new int[]{ 1,2,3,4,5});

            Console.WriteLine(aaa["234243"]);

            Console.WriteLine(aaa[2]);

        }
    }
  
}

