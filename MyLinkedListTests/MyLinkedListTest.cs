using System;
using Xunit;
using MyLinkedList;

namespace MyLinkedListTests
{
    public class MyLinkedListTest
    {
        [Fact]
        public void CountTest()
        {
            MyDoubleLinkedList<string> testList = new();

            Assert.Equal(0, testList.Count);

            testList.AddFirst("");
            testList.AddLast("last");
            testList.AddFirst("first");
            testList.AddFirst("first again");

            Assert.Equal(4, testList.Count);
        }

        [Fact]
        public void ContainsTest()
        {
            MyDoubleLinkedList<int> testList = new();

            Assert.False(testList.Contains(0));

            testList.AddFirst(0);

            Assert.True(testList.Contains(0));

            testList.AddLast(99);
            testList.AddLast(-18);
            testList.AddFirst(2);
            testList.AddFirst(14);

            Assert.True(testList.Contains(99));
            Assert.True(testList.Contains(2));
            Assert.True(testList.Contains(-18));
            Assert.True(testList.Contains(14));
            Assert.False(testList.Contains(1000));
        }

        [Fact]
        public void IndexerExceptionTest()
        {
            MyDoubleLinkedList<char> testList = new();

            Assert.Throws<ArgumentOutOfRangeException>(() => testList[0]);

            testList.AddFirst('2');
            testList.AddFirst('c');

            Assert.Throws<ArgumentOutOfRangeException>(() => testList[3]);
            Assert.Throws<ArgumentOutOfRangeException>(() => testList[-2]);
        }

        [Fact]
        public void IndexerTest()
        {
            MyDoubleLinkedList<int> testList = new();

            testList.AddFirst(0);
            testList.AddFirst(2);
            testList.AddFirst(4);

            Assert.Equal(0, testList[2]);
            Assert.Equal(2, testList[1]);
            Assert.Equal(4, testList[0]);
        }

        [Fact]
        public void AddFirstTest()
        {
            MyDoubleLinkedList<int> testList = new();

            testList.AddFirst(-1);
            Assert.Equal(-1, testList.First.Value);

            testList.AddFirst(1);
            Assert.Equal(1, testList.First.Value);

            testList.AddLast(3);
            Assert.Equal(1, testList.First.Value);
        }

        [Fact]
        public void AddLastTest()
        {
            MyDoubleLinkedList<int> testList = new();

            testList.AddLast(-1);
            Assert.Equal(-1, testList.Last.Value);

            testList.AddLast(1);
            Assert.Equal(1, testList.Last.Value);

            testList.AddFirst(3);
            Assert.Equal(1, testList.Last.Value);
        }

        [Fact]
        public void ReverseTest()
        {
            MyDoubleLinkedList<int> testList = new();

            testList.AddFirst(1);
            testList.AddLast(2);
            testList.AddLast(3);
            testList.AddLast(4);
            testList.AddLast(5);
            testList.Reverse();

            Assert.Equal(5, testList[0]);
            Assert.Equal(4, testList[1]);
            Assert.Equal(3, testList[2]);
            Assert.Equal(2, testList[3]);
            Assert.Equal(1, testList[4]);
        }
    }
}
