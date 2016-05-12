using System;

namespace MacExercise
{
    public  delegate int testDelegate();

    class Test: INewInterface
    {
        #region INewInterface implementation

        public virtual void WriteSomething(string sth)
        {
            throw new NotImplementedException();
        }

        #endregion
        

    }

}

