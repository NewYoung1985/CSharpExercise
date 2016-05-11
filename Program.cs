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
            Horse h = new Horse();
            Whale w = new Whale();
            Mammal m = new Mammal();
            Mammal temp;

            h.ShowType();
            w.ShowType();
            m.ShowType();

            temp = h;
            temp.ShowType();

            temp = w;
            temp.ShowType();

        }
    }

}
