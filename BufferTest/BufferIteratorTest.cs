using NUnit.Framework;
using Moq;
using BufferEnumerable;
using System.Collections.Generic;

namespace BufferTest
{
    public class BufferIteratorTest
    {
        [SetUp]
        public void Setup() { }
        [Test]
        public void TestError()
        {
            TestIterator testIterator = new TestIterator();
            Iterator<int> iterator = new Iterator<int>(testIterator.GetIterator());
            var x = iterator.GetEnumerator();
            Assert.IsTrue(x.GetType() != typeof(List<int>.Enumerator));
        }
        [Test]
        public void TestBufferIntegrity()
        {
            TestIterator testIterator = new TestIterator();
            Iterator<int> iterator = new Iterator<int>(testIterator.GetIterator());
            iterator.GetEnumerator().MoveNext();
            var x = iterator.GetEnumerator();
            Assert.IsTrue(x.GetType() != typeof(List<int>.Enumerator));
        }
        [Test]
        public void TestBuffer()
        {
            TestIterator testIterator = new TestIterator();
            Iterator<int> iterator = new Iterator<int>(testIterator.GetIterator());
            foreach (var item in iterator){ }
            var x = iterator.GetEnumerator();
            Assert.IsTrue(x.GetType() == typeof(List<int>.Enumerator));
        }
        [Test]
        public void TestIntegrity()
        {
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            TestIterator testIterator = new TestIterator();
            Iterator<int> iterator = new Iterator<int>(testIterator.GetIterator());
            foreach (var item in iterator)
            {
                one.Add(item);
            }
            foreach (var item in iterator)
            {
                two.Add(item);
            }
            CollectionAssert.AreEqual(one, two);
        }

    }
}