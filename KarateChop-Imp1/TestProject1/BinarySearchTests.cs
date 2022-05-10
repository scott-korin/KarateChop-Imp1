using NUnit.Framework;

namespace Search
{
	[TestFixture]
	public class BinarySearchTests
	{
		BinarySearch search;

		[SetUp]
		public void Setup()
		{
			search = new BinarySearch();
		}

		[Test]
		[TestCase(-1, 3, null, TestName = "ChopNullArrayReturnsNegativeOne")]
		[TestCase(-1, 3, new int[0], TestName = "ChopEmptyArrayReturnsNegativeOne")]
		[TestCase(-1, 3, new int[] { 1 }, TestName = "ChopOneItemArrayWithNoMatchReturnsNegativeOne")]
		[TestCase(0, 1, new int[] { 1 }, TestName = "ChopOneItemArrayWithMatchReturnsZero")]
		[TestCase(0, 1, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayMatchFirstItemReturnsZero")]
		[TestCase(1, 3, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayMatchSecondItemReturnsOne")]
		[TestCase(2,  5, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayMatchSecondItemReturnsTwo")]
		[TestCase(-1, 0, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch")]
		[TestCase(-1, 2, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch")]
		[TestCase(-1, 4, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch")]
		[TestCase(-1, 6, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch")]
		[TestCase(0,  1, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchFirstItemReturnsZero")]
		[TestCase(1,  3, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchSecondItemReturnsOne")]
		[TestCase(2,  5, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchThirdItemReturnsTwo")]
		[TestCase(3,  7, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchFourthItemReturnsThree")]
		[TestCase(-1, 0, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch")]
		[TestCase(-1, 2, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch")]
		[TestCase(-1, 4, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch")]
		[TestCase(-1, 6, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch")]
		[TestCase(-1, 8, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch")]
		public void Chop(int expectedIndex, int query, int[] array)
		{
			Assert.AreEqual(expectedIndex, search.Search(query, array), "Searching an array of {0} items for the value {1} did not return {2}.", array == null ? "NULL" : array.Length, query, expectedIndex);
		}

		[TestCase(0, 0, TestName = "ChopBigArrayMatchFirstElementReturnsZero")]
		[TestCase(9, 18, TestName = "ChopBigArrayMatchTenthElementReturnsNine")]
		[TestCase(99, 198, TestName = "ChopBigArrayMatchOneHundrenthElementReturnsNinetyNine")]
		[TestCase(49999, 99998, TestName = "ChopBigArrayMatchHalfwayElementReturns49999")]
		[TestCase(670000, 1340000, TestName = "ChopBigArrayValueInSecondHalfOfElement")]
		[TestCase(999999, 1999998, TestName = "ChopBigArrayMatchLastValue")]
		[TestCase(-1, 1, TestName = "ChopBigArrayMatchNoElementReturnsNegativeOne")]
		public void ChopBigArray(int expectedIndex, int query)
		{
			int[] evenArray = new int[1000000];
			for(int i = 0; i < evenArray.Length; i++)
			{
				evenArray[i] = i * 2;
			}

			Assert.AreEqual(expectedIndex, search.Search(query, evenArray), "Searching an array of {0} items for the value {1} did not return {2}.", evenArray.Length, query, expectedIndex);

		}
	}
}