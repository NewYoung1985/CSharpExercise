using System;

namespace MacExercise
{
    public class GenericExample<T> where T:IComparable
    {
        public GenericExample()
        {
        }

        private T data;

        public T ReturnData()
        {
            return this.data;
        }

    }
}

