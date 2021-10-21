using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> linkedList;
        public Deque()
        {
            linkedList = new LinkedList<T>;
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Front => linkedList.First.Value;

        public T Back => linkedList.Last.Value;

        public void AddBack(T item)
        {
            linkedList.AddLast(item);
        }

        public void AddFront(T item)
        {
            linkedList.AddFirst(item);
        }

        public T RemoveBack()
        {
            T lastItem = linkedList.Last.Value;
            linkedList.RemoveLast();
            return lastItem;
        }

        public T RemoveFront()
        {
            T firstItem = linkedList.First.Value;
            linkedList.RemoveLast();
            return firstItem;
        }
    }
}
