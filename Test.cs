using System;

namespace MacExercise
{
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

