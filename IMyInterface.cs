using System;

namespace MacExercise
{
    public interface IMyInterface<T>
    {
        T GetData();

        void SetData(T data);
    }

    public interface IMyInterfaceGet<out T>
    {
        T GetData();
    }

    public interface IMyInterfaceSet<T>
    {
        void SetData(T data);
    }
}

