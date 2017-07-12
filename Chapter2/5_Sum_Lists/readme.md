# Partition

You have two numbers represented by a liked list, where each node contains a single digit.
The digits are stored in reverse order, such that the 1's digit is at the head of the list.

Write a function that adds the two numbers and returns the sum as a linked list.

## Example

Input: (7 -> 1 -> 6) + (5 -> 9 -> 2). That is, 617+295.
Output: 2 -> 1 -> 9. That is, 912.


## Solution

We'll walk through both linked lists and sum each pair of digits with the carrying value (if any).
Then we'll append the least significant digit into the result, and pass the most significant digit as carrying.

### One iteration


Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
One iteration  | O(n)                | O(1)

- **n** - number of elements of the linked list.