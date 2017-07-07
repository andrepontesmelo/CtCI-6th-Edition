# Partition

Implement an algorithm to partition a linked list around a value x,
such that all nodes less than x come before all nodes greater then or equal to x.

## Solution

### One iteration

We'll need to pass over the linked list only once. In this process, we'll be appending nodes to two new linked lists. One for values less then x, and other for values greater then or equal to x.

In the end of the process, we'll append the lower-values linked list in the start of the higher values one. 


Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
One iteration  | O(n)                | O(1)

- **n** - number of elements of the linked list.