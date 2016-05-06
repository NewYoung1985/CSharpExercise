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

            OperatorTraining aaa = new OperatorTraining(55);

            OperatorTraining bbb = new OperatorTraining(55);

            OperatorTraining ccc = aaa + 5;

            Console.WriteLine(ccc.Value);

        }
    }

}
