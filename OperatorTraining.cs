using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacExercise
{
    class OperatorTraining
    {
        private int value;

        public int Value
        {
            get { return this.value; }
        }

        public OperatorTraining()
        {

        }

        public OperatorTraining(int value)
        {
            this.value = value;
        }

        public static OperatorTraining operator +(OperatorTraining lhsValue, OperatorTraining rhsValue)
        {
            return new OperatorTraining(lhsValue.value + rhsValue.value);
        }

        public static OperatorTraining operator +(OperatorTraining lhsValue, int rhsValue)
        {
            return new OperatorTraining(lhsValue.value + rhsValue);
        }
        

        public static implicit operator int(OperatorTraining source)
        {
            return source.value;
        }

    }
}
