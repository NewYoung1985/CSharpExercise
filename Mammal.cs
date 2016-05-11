using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacExercise
{
    class Mammal
    {
        public virtual void ShowType()
        {
            Console.WriteLine("This is Mammal");
        }
    }

    class Horse:Mammal
    {
        new public void ShowType()
        {
            Console.WriteLine("This is Horse");
        }
    }

    class Whale:Mammal
    {
        public override void ShowType()
        {
            Console.WriteLine("This is Whale");
        }
    }

    static class ExtendMethod
    {
        public static void PlusOne(this Mammal i, ref int j)
        {
            j++;
            Console.WriteLine(j);
        }
    }
}
