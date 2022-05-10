using Search;
using System.Diagnostics;

int[] evenArray = new int[1000000];
for (int i = 0; i < evenArray.Length; i++)
{
	evenArray[i] = i * 2;
}

Stopwatch watch = new Stopwatch();
watch.Start();
BinarySearch search = new BinarySearch();
int index = search.Chop(1999998, evenArray);
watch.Stop();

Console.WriteLine("Binary Search for last item in array of {0}, Index is {1}.  Ellapsed time: {2}ms", evenArray.Length, index, watch.ElapsedMilliseconds);


watch.Start();
search = new BinarySearch();
index = search.Chop(1, evenArray);
watch.Stop();

Console.WriteLine("Binary Search for item not in array of {0} items, Index is {1}.  Ellapsed time: {2}ms", evenArray.Length, index, watch.ElapsedMilliseconds);


watch.Start();
BruteForceSearch bruteSearch = new BruteForceSearch();
index = bruteSearch.Search(1999998, evenArray);
watch.Stop();

Console.WriteLine("Brute Force Search for last item in array of {0}, Index is {1}.  Ellapsed time: {2}ms", evenArray.Length, index, watch.ElapsedMilliseconds);


watch.Start();
bruteSearch = new BruteForceSearch();
index = bruteSearch.Search(1, evenArray);
watch.Stop();

Console.WriteLine("Brute Force Search for item not in array of {0} items, Index is {1}.  Ellapsed time: {2}ms", evenArray.Length, index, watch.ElapsedMilliseconds);