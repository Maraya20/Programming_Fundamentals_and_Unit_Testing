using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class ListRemover_RemoveLessThanOrEqualToTests
    {
        [Test]
        public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmptyList()
        {
            // Arrange
            List<int> inputList = new List<int>();
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(inputList, threshold);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmptyList()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(inputList, threshold);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
        {
            // Arrange
            List<int> inputList = new List<int> { 6, 7, 8, 9, 10 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(inputList, threshold);

            // Assert
            Assert.AreEqual(inputList, result);
        }

        [Test]
        public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
        {
            // Arrange
            List<int> inputList = new List<int> { 1, 3, 5, 7, 9 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(inputList, threshold);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 7, 9 }, result);
        }

        [Test]
        public void Test_RemoveElementsLessThanOrEqualTo_ListWithAllValuesEqualToThreshold_ReturnsEmptyList()
        {
            // Arrange
            List<int> inputList = new List<int> { 5, 5, 5, 5 };
            int threshold = 5;

            // Act
            List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(inputList, threshold);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
