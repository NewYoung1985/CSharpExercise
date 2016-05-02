using System;
using System.Collections;
using System.Collections.Generic;

namespace MacExercise
{
    public class ClassIDissposable:IDisposable
    {
        public ClassIDissposable()
        {
        }

        #region IDisposable implementation

        void IDisposable.Dispose()
        {
            Console.WriteLine("Dispose");
        }

        #endregion
    }
}

