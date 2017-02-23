# Remove Dups

Write code to remove duplicates from an unsorted linked list.

## Solution

## Using a temporary buffer

We can keep a hashset of all distinct values. So the algorithm would be to iterate over the linkedlist. If the current item is in the hashset then remove it from the linkedlist, otherwise add current element to the hashset and move forward.

The space complexity is O(n) since we would need to store all the values in the set. In the worse case there are no duplicates hence all values needs to be stored in the hashset.

Solution                 | Run-time Complexity | Space Complexity
------------------------ | ------------------- | ----------------
Using a temporary buffer | O(n)                | O(n)

- **n** - number of elements of the linked list.
