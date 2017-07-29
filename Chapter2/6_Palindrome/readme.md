# Palindrome

Implement a function to check if a linked list is a palindrome.

## Solution

### Reverse

We'll create a new linked list by reversing the input.
Despite requiring memory allocation for the new list, it will make the problem easier: 
we just need to compare the input with it's reversed copy.

If the input is a palindrome, then it should match it's reversed version.

### Stack

We can use a stack to put the characters until we reach the middle of the string.
Then we start popping the elements from stack and compare if it matches the end of the string.
In order to know if we reach the middle of the string, we can count it.

Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
Reverse        | O(n)                | O(n)
Stack          | O(n)                | O(n)

- **n** - number of characters of the input string


