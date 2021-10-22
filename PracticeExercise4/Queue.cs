using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Queue<T> : IQueue<T>
    {
        private LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();

        }

        public T First
        {
            get
            {
                T first;
                try
                {
                    first = linkedList.First.Value;
                }
                catch (NullReferenceException)
                {
                    throw new EmptyQueueException();
                }
                return first;
            }
        }

        public T Last 
        {
            get
            {
                T last;
                try
                {
                    last = linkedList.Last.Value;
                }
                catch (NullReferenceException)
                {
                    throw new EmptyQueueException();
                }
                return last;
            }
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Dequeue()
        {
            if( IsEmpty )
            {
                throw new EmptyQueueException();
            }

            T firstItem = linkedList.First.Value;

            linkedList.RemoveFirst();

            return firstItem;
        }

        public void Enqueue(T item)
        {
            linkedList.AddLast(item);
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
