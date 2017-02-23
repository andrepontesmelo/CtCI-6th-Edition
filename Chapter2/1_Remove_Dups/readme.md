# Remove Dups

Write code to remove duplicates from an unsorted linked list.

## Solution

## Using a temporary buffer

We can keep a hashset of all distinct values. So the algorithm would be to iterate over the linkedlist. If the current item is in the hashset then remove it from the linkedlist, otherwise add current element to the hashset and move forward.

The space complexity is O(n) since we would need to store all the values in the set. In the worse case there are no duplicates hence all values needs to be stored in the hashset.

## Without using a temporary buffer

We'll need two pointers. The first will iterate over the linked list. The second will iterate from the first pointer until the end of the linked list. When the second pointer points to the value of first pointer, then start pointing to the next node, pointed by second pointers. In other words, the second iteration will delete any occurrences of duplicated values.

Solution                         | Run-time Complexity | Space Complexity
-------------------------------- | ------------------- | ----------------
Using a temporary buffer         | O(n)                | O(n)
Without using a temporary buffer | O(n^2)              | O(1)

- **n** - number of elements of the linked list.
