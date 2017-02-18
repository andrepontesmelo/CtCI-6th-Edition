# URLify
White a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the true length of the string. Use a character array so that you can perform this operation in place.

## Solution
 * Iterate over the string and count the spaces.
 * Iterate over the string from end to start and copy each character to final position.


Solution               | Runtime Complexity    | Space Complexity
---------------------- | --------------------- | ----------------
2 Iterations           | O(n)                  | O(1)

 * **n** - length of string
