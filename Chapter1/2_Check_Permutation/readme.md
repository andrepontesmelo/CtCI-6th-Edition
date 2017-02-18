# Check Permutation

Given two strings, write a method to decide if one is a permutation of the other.

## Solutions

**Search space cut:** If length of strings are different then return false since one cannot be a permutation of the other.

- Brute-force

  - Compute all permutations of smallest. String s has s! permutations.
  - Add those permutations into a HashSet.
  - Return if biggest string is in the HashSet.

- Compare sorted strings

  - Sort the characters of each string using merge-sort.
  - Do a linear comparison to check if both are the same.

- Occurrences array

  - Let's suppose the strings use **b** bits for each character.
  - We'll use as additional space **A** an array of integers of fixed size **2^b**. (256 for ASCII).
  - Iterate over the first string, incrementing **A[c]**, where **c** is the order of current character. In the end of this loop, the array will contain the count of each character.
  - Iterate over the second string, decrementing **A[c]**.
  - Iterate over the array **A**. All values should be zero if one string is a permutation of the other.

Solution               | Runtime Complexity    | Space Complexity
---------------------- | --------------------- | ----------------
Brute-force             | O(s!)                 | O(s!)
Compare sorted strings | O(n*lg(n))            | O(1)
Occurrences array      | O(max(n, 2^b)) = O(n) | O(2^b) = O(1)

- **n** - Length of biggest string.
- **b** - Bit length for each character. ASCII: **b=8**. Unicode: **b=16**.
