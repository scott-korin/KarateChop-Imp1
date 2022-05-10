namespace Search
{
	public class BinarySearch
	{
		public int Chop(int query, int[] sortedArray)
		{
			if (sortedArray == null || sortedArray.Length == 0)
				return -1;

			if (sortedArray.Length == 1)
				if (sortedArray[0] == query)
					return 0;
				else
					return -1;

			return Recurse(query, sortedArray, 0, sortedArray.Length - 1);

		}

		private static int Recurse(int query, int[] sortedArray, int min, int max)
		{
			if (min > max)
			{
				return -1;
			}
			else
			{
				int middleIndex = (min + max) / 2;
				if (sortedArray[middleIndex] == query)
					return middleIndex;
				else if (sortedArray[middleIndex] > query)
					return Recurse(query, sortedArray, min, middleIndex - 1);
				else
					return Recurse(query, sortedArray, middleIndex + 1, max);
			}
		}
	}
}