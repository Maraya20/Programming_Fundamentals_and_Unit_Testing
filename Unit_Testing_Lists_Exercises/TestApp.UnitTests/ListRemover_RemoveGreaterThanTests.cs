using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class ListRemover_RemoveGreaterThanTests
    {
        [Test]
        public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmptyList()
        {
            // Arrange
            List<int> inputList = new List<int>();
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsGreaterThan(inputList, threshold);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmptyList()
        {
            // Arrange
            List<int> inputList = new List<int> { 6, 7, 8, 9, 10 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsGreaterThan(inputList, threshold);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsGreaterThan(inputList, threshold);

            // Assert
            Assert.AreEqual(inputList, result);
        }

        [Test]
        public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 3, 5, 7, 9 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsGreaterThan(inputList, threshold);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5 }, result);
        }

        [Test]
        public void Test_RemoveElementsGreaterThan_ListWithAllValuesEqualToThreshold_ReturnsSameList()
        {
            // Arrange
            List<int> inputList = new List<int> { 5, 5, 5, 5 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsGreaterThan(inputList, threshold);

            // Assert
            CollectionAssert.AreEqual(inputList, result);
        }
    }
}
