using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MacExercise
{
    enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter}

    ;

    delegate void GetNames(int arg1,int arg2);

    struct AnyTest
    {

        private int x;

        public int X { get; set; }

        public GetNames nowgetname;

        public void ToDo()
        {
            Console.WriteLine(X);
        }
        
       
    }
}
