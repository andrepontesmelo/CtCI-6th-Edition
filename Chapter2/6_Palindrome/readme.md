# Palindrome

Implement a function to check if a linked list is a palindrome.

## Solution

### Reverse

We'll create a new linked list by reversing the input.
Despite requiring memory allocation for the new list, it will make the problem easier: 
we just need to compare the input with it's reversed copy.

If the input is a palindrome, then it should match it's reversed version.

### Recursive

We'll work with two Node pointers. One will be passed as parameter and will iterate over all the input string.
The other will be returned in the result of the recursive function. This last node will be the character in the 
right side of the string that needs to be compared with the corresponding one in the left side.

We'll need to know the size of the string from the beginning, and will pass as argument a countdown that will start as the full length and will be zero in the middle of the string. For each iteration of the recursive call, we'll decrement the countdown by two.

Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
Reverse        | O(n)                | O(n)
Recursive      | O(n)                | O(n)

- **n** - number of characters of the input string