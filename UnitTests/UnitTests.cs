using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercise4;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestStackPush()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());

        }

        [TestMethod]
        public void TestStackPop()
        {
            // judah
        }

        [TestMethod]
        public void TestStackPeek()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());

            stack.Pop();
            Assert.AreEqual(5, stack.Peek());
            Assert.AreEqual(4, stack.Length);
            Assert.AreEqual("5\n3\n2\n1\n", stack.ToString());

            stack.Pop();
            Assert.AreEqual(3, stack.Peek());
            Assert.AreEqual(3, stack.Length);
            Assert.AreEqual("3\n2\n1\n", stack.ToString());
        }

        [TestMethod]
        public void TestStackLength()
        {
            // danny
        }

        [TestMethod]
        public void TestStackIsEmpty()
        {
            // kelly
        }



        [TestMethod]
        public void TestQueueDequeue()
        {
            // lauren 
        }

        [TestMethod]
        public void TestQueueEnqueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

            queue.Enqueue(6);
            queue.Enqueue(7);

            Assert.AreEqual(7, queue.Length);
            Assert.AreEqual("<Back> 7 → 6 → 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

        }

        [TestMethod]
        public void TestQueueFirst()
        {
            // savannah 
        }

        [TestMethod]
        public void TestQueueLast()
        {
            // zach
        }

        [TestMethod]
        public void TestQueueIsEmpty()
        {
            // kenan
        }

        [TestMethod]
        public void TestQueueLength()
        {
            // john allen
        }

        [TestMethod]
        public void TestDequeAddFront()
        {
            // sean
        }

        [TestMethod]
        public void TestDequeAddBack()
        {
            // tristan
        }

        [TestMethod]
        public void TestDequeRemoveFront()
        {
            // madison 
        }

        [TestMethod]
        public void TestDequeRemoveBack()
        {
            // kenan
        }


        [TestMethod]
        public void TestDequeIsEmpty()
        {
            // kenan
        }

        [TestMethod]
        public void TestDequeLength()
        {
            // kenan
        }

        [TestMethod]
        public void TestDequeFront()
        {
            // kenan
        }

        [TestMethod]
        public void TestDequeBack()
        {
            // kenan 
        }
    }
}
