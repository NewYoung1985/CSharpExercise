using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacExercise
{
    class InheritanceExerciseBase
    {
        public virtual void Talk()
        {
            Console.WriteLine("This is base");
        }

        public void ABC(ref int i)
        {
            i++;

            Console.WriteLine(i);
        }

    }

    class InheritanceExercise1 : InheritanceExerciseBase
    {
        public override void Talk()
        {
            Console.WriteLine("This is 1");
        }
    }

    class InheritanceExercise2:InheritanceExerciseBase
    {
        new public void Talk()
        {
            Console.WriteLine("This is 2");
        }
    }

    static class ExtendMethod
    {
        public static void PlusOne(this InheritanceExerciseBase i, ref int j)
        {
            j++;
            Console.WriteLine(j);
        }
    }
}
