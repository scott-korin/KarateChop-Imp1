using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
	public class BruteForceSearch
	{

		public int Search(int query, int[] sortedArray)
		{
			if (sortedArray == null || sortedArray.Length == 0)
				return -1;

			for(int i = 0; i < sortedArray.Length; i++)
			{
				if (sortedArray[i] == query)
					return i;
			}
			return -1;
		}
	}
}
