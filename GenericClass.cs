using System;

namespace MacExercise
{
    public class GenericClass<T>:IMyInterfaceGet<T>,IMyInterfaceSet<T>
    {
        public GenericClass()
        {
        }


        private T data;

        #region IMyInterfaceGet implementation

        T IMyInterfaceGet<T>.GetData()
        {
            return this.data;
        }

        #endregion

        #region IMyInterfaceSet implementation

        void IMyInterfaceSet<T>.SetData(T data)
        {
            this.data = data;
        }

        #endregion
    }
}

