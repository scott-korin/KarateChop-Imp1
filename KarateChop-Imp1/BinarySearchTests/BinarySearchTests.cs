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
		[TestCase(-1, 0, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch0")]
		[TestCase(-1, 2, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch2")]
		[TestCase(-1, 4, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch4")]
		[TestCase(-1, 6, new int[] { 1, 3, 5 }, TestName = "ChopThreeItemArrayWithNoMatch6")]
		[TestCase(0,  1, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchFirstItemReturnsZero")]
		[TestCase(1,  3, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchSecondItemReturnsOne")]
		[TestCase(2,  5, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchThirdItemReturnsTwo")]
		[TestCase(3,  7, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayMatchFourthItemReturnsThree")]
		[TestCase(-1, 0, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch0")]
		[TestCase(-1, 2, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch2")]
		[TestCase(-1, 4, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch4")]
		[TestCase(-1, 6, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch6")]
		[TestCase(-1, 8, new int[] { 1, 3, 5, 7 }, TestName = "ChopFourItemArrayWithNoMatch8")]
		public void Chop(int expectedIndex, int query, int[] array)
		{
			Assert.AreEqual(expectedIndex, search.Chop(query, array), "Searching an array of {0} items for the value {1} did not return {2}.", array == null ? "NULL" : array.Length, query, expectedIndex);
		}
	}
}