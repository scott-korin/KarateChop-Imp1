# KarateChop-Imp1
My First implementation of Kata02:  Karate Chop (http://codekata.com/kata/kata02-karate-chop/)


## Implementation Notes
I use a TDD approach were I wrote a test case for each test as mentioned in the post, then implemented the code necessary.  The first iteration was a brute force search, which was not the end goal.  However, once I had all tests passed, I then went back and changed the `Chop` function to be a binary search using recursion.  My first attempt used `Array.Copy` to create a smaller copy of the array, but that took more memory than I was happy with, so I changed the implementation to move maintain a min and max pointer instead.

Once I was confident it was correct, I wrote the console app to test the difference in speed between the binary search and a brute force search.

## Specification
Write a binary chop method that takes an integer search target and a sorted array of integers. It should return the integer index of the target in the array, or -1 if the target is not in the array. The signature will logically be:

`chop(int, array_of_int)  -> int`

You can assume that the array has less than 100,000 elements. For the purposes of this Kata, time and memory performance are not issues (assuming the chop terminates before you get bored and kill it, and that you have enough RAM to run it).
