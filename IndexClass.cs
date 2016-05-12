using System;

namespace MacExercise
{
    public class IndexClass
    {
        public IndexClass()
        {
        }

        public IndexClass(int[] numbers)
        {
            this.numbers = numbers;
        }

        private int[] numbers;

        public int this [int index]
        {
            get
            {
                return this.numbers[index];
            }
            set
            {
                this.numbers[index] = value;
            }
        }


        public int this[string index]
        {
            get
            {
                return this.numbers[0];
            }
            set
            {
                this.numbers[0] = value;
            }
        }

    }
}

