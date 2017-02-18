# Palindrome Permutation

Given a string, write a function to check if it is a permutation of a palindrome.

## Solutions

The given string is a permutation of a palindrome only if there is at most one character with an odd number of occurrences. The palindrome **S** can be can in the form of an odd or even number of characters. For instance, it can assume the form 'abc...cba' OR the form 'abcwcba'. In other words, the only palindrome with an even number of characters is the one formed with a single character in the middle surrounded by characters that the count is even.

- Sorting

  - Sort the characters of the input string using merge-sort.
  - Iterate over the string, and count how many consecutive characters we have.
  - If the count for a given character is even, continue.
  - If the count is odd for more then one character, then it is not a permutation of a palindrome.
  - If after the iteration, there is at most one character with odd count, then it is a permutation of a palindrome.

- Array count

  - Allocate an array **A** of integers with length **2^b** where **b** is the number of bits of one character. It might be 256 for ASCII or 2^16 for Unicode.
  - Iterate over the string, counting the frequency of each character.
  - Iterate over **A** If more then one character have an odd count, then it is not a palindrome permutation. It will be a palindrome permutation otherwise.

Solution    | Run-time Complexity | Space Complexity
----------- | ------------------ | ----------------
Sorting     | O(n*lg(n)          | O(1)
Array count | O(n)               | O(1)

- **n** - length of string
