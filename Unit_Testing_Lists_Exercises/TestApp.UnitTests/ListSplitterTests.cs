using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class ListSplitterTests
    {
        [Test]
        public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
        {
            // Arrange
            List<int> inputList = new List<int>();

            // Act
            var (evens, odds) = ListSplitter.SplitEvenAndOdd(inputList);

            // Assert
            Assert.IsEmpty(evens);
            Assert.IsEmpty(odds);
        }

        [Test]
        public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
        {
            // Arrange
            List<int> inputList = new List<int> { 2, 4, 6, 8, 10 };

            // Act
            var (evens, odds) = ListSplitter.SplitEvenAndOdd(inputList);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10 }, evens);
            Assert.IsEmpty(odds);
        }

        [Test]
        public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 3, 5, 7, 9 };

            // Act
            var (evens, odds) = ListSplitter.SplitEvenAndOdd(inputList);

            // Assert
            Assert.IsEmpty(evens);
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9 }, odds);
        }

        [Test]
        public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var (evens, odds) = ListSplitter.SplitEvenAndOdd(inputList);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10 }, evens);
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9 }, odds);
        }

        [Test]
        public void Test_SplitEvenAndOdd_ListContainingZero_ZeroGoesToEvenList()
        {
            // Arrange
            List<int> inputList = new List<int> { 0, 1, 2, 3, 4 };

            // Act
            var (evens, odds) = ListSplitter.SplitEvenAndOdd(inputList);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 0, 2, 4 }, evens);
            CollectionAssert.AreEqual(new List<int> { 1, 3 }, odds);
        }
    }
}
