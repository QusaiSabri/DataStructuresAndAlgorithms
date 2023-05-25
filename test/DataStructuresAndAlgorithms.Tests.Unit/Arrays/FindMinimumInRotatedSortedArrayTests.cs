using System;
using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Unit.Arrays
{
	public class FindMinimumInRotatedSortedArrayTests
	{
        [Theory]
        [InlineData(new int[] { 3, 4, 5, 1, 2 }, 1)]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [InlineData(new int[] { 11, 13, 15, 17 }, 11)]
        public void FindMin_ShouldReturnMinimumElement(int[] nums, int expected)
        {
            // Arrange
            var findMinimumInRotated = new FindMinimumInRotatedSortedArray();

            // Act
            var result = findMinimumInRotated.SolveWithBinarySearch(nums);

            // Assert
            result.Should().Be(expected);
        }
    }
}

