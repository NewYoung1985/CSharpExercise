using System;
using System.Collections;

namespace MacExercise
{
    public class ArrayExercise
    {
        public ArrayList eArrayList = new ArrayList();
        public Queue eQueue = new Queue();
        public Stack eStack = new Stack();
        public Hashtable eHashtable = new Hashtable();
        public SortedList eSortedList = new SortedList();

        public ArrayExercise()
        {
        }

        public void CreatArrayList(Array dataList)
        {

            foreach (object data in dataList)
            {
                eArrayList.Add(data);
            }

        }

        public void CreatQueue(Array dataList)
        {

            foreach (object data in dataList)
            {
                eQueue.Enqueue(data);
            }

        }

        public void CreatStack(Array dataList)
        {

            foreach (object data in dataList)
            {
                eStack.Push(data);
            }

        }

        public void CreatHashtable(Array dataList)
        {
            int i = 0;
            foreach (object data in dataList)
            {
                eHashtable.Add(i++, data);
            }

        }

        public void CreatSortedList(Array dataList)
        {
            int i = 0;
            foreach (object data in dataList)
            {
                eSortedList.Add(string.Format("{0}{1}", "#", i++), data);
            }

        }

    }
}

