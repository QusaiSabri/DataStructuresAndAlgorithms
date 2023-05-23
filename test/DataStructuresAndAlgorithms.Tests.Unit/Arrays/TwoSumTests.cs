

using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Unit.Arrays
{

    public class TwoSumTests
    {
        [Fact]
        public void SolveWithHashMap_ShouldReturnIndicesOfTwoNumbers_ThatAddUpToTarget()
        {
            // Arrange
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            var result = twoSum.SolveWithHashMap(nums, target);

            // Assert
            result.Should().BeEquivalentTo(new int[] { 0, 1 });


        }
    }
}
