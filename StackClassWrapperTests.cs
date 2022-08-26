using System;
using NUnit.Framework;
using WarmUpStackClass;

namespace StackClassTests
{
    public class Tests
    {
        private StackClassWrapper stackClass;
        private object value1 = 1;
        private object value2 = "hi";

        [SetUp]
        public void Setup()
        {
            stackClass = new StackClassWrapper();
        }

        [Test]
        public void TestStackPushShouldReturnLastValueOnPeek()
        {
            AddValuesToStack();

            Assert.IsTrue(stackClass.Peek() == value2);
            Assert.IsTrue(stackClass.Peek() == value2);
        }

        [Test]
        public void StackShouldThrowOnEmptyPop()
        {
            Assert.Throws<InvalidOperationException>(() => stackClass.Pop());
        }

        [Test]
        public void StackShouldReturnLastValueOnPop()
        {
            AddValuesToStack();
            Assert.IsTrue(stackClass.Pop() == value2);
            Assert.IsTrue(stackClass.Pop() == value1);
        }


        private void AddValuesToStack()
        {
            stackClass.Push(value1);
            stackClass.Push(value2);
        }
    }
}