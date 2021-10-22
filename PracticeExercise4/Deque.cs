using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> linkedList;
        public Deque()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Front 
        {
            get
            {
                T front;
                try
                {
                    front = linkedList.First.Value;
                }
                catch (NullReferenceException)
                {
                    throw new EmptyQueueException();
                }
                return front;
            }
        }

        public T Back
        {
            get
            {
                T back;
                try
                {
                    back = linkedList.Last.Value;
                }
                catch (NullReferenceException)
                {
                    throw new EmptyQueueException();
                }
                return back;
            }
        }

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
            if (IsEmpty)
                throw new EmptyQueueException();
            T lastItem = linkedList.Last.Value;
            linkedList.RemoveLast();
            return lastItem;
        }

        public T RemoveFront()
        {
            if (IsEmpty)
                throw new EmptyQueueException();
            T firstItem = linkedList.First.Value;
            linkedList.RemoveFirst();
            return firstItem;
        }
        public override string ToString()
        {
            string result =  "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if(currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}
