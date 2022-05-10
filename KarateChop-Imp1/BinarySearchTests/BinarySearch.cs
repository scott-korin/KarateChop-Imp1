namespace Search
{
	public class BinarySearch
	{
		public int Search(int query, int[] sortedArray)
		{
			if (sortedArray == null || sortedArray.Length == 0)
				return -1;

			if (sortedArray.Length == 1)
				if (sortedArray[0] == query)
					return 0;
				else
					return -1;

			int halfwayIndex = sortedArray.Length / 2;
			int halfwayValue = sortedArray[halfwayIndex];

			if (halfwayValue == query)
				return halfwayIndex;

			if (halfwayValue > query)
				return Search(query, SliceArray(sortedArray, 0, halfwayIndex));

			int topHalfIndex = Search(query, SliceArray(sortedArray, halfwayIndex, sortedArray.Length - halfwayIndex));
			if (topHalfIndex > -1)
				topHalfIndex += halfwayIndex;
			return topHalfIndex;
		}

		private static int[] SliceArray(int[] source, int index, int length)
		{
			int[] slice = new int[length];
			Array.Copy(source, index, slice, 0, length);
			return slice;
		}
	}
}