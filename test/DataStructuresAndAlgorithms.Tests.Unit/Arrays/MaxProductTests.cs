using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Unit.Arrays
{
    public class MaxProductTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { 0, 2 }, 2)]
        public void MaxProduct_ShouldReturnMaximumProductOfSubarray(int[] nums, int expected)
        {
            // Arrange
            var subarray = new MaximumProductSubarray();

            // Act
            var result = subarray.MaxProduct(nums);

            // Assert
            result.Should().Be(expected);
        }
    }
}
