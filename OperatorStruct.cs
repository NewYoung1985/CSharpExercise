using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacExercise
{
    struct OperatorStruct
    {
        private int value;

        public static implicit operator int(OperatorStruct source)
        {
            return source.value;
        }
    }
}
