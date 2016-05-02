using System;

namespace MacExercise
{
    public class ClassDelegate
    {
        public ClassDelegate()
        {
        }

        public delegate void DDD();

        public event DDD WriteSth;

        private void aaa()
        {
            Console.WriteLine("aaa");
        }

        private void bbb()
        {
            Console.WriteLine("bbb");
        }

        private void ccc()
        {
            Console.WriteLine("ccc");
        }

        public DDD ttttt;

        public void Controler()
        {
            ttttt += aaa;
            ttttt += bbb;
            ttttt += ccc;
        }

        public void GetReady()
        {
            WriteSth += aaa;
            WriteSth += bbb;
            WriteSth += ccc;
        }

        public void WriteNow()
        {
            if (WriteSth != null)
            {
                WriteSth();
            }
        }

    }
}

