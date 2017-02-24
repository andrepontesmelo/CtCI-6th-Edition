# Return Kth to Last

Implement an algorithm to find the **K**th to last element of a singly linked list.

## Solution

### Two iterations

We'll need first to iterate over the list to count the elements. Then we need to iterate once again to get the element at that position.

### One iteration

Let's use two pointers: **p1** and **p2**. We can use **p1** to iterate over the linked list. In the meantime we count the nodes passing by **p1**. When we reach **K** nodes, **p2** will start iterating over the linked list.

In this solution we have only one loop, where both pointers will be incremented by one, and the difference between them are **K** nodes. By the time the pointer **p1** reaches the end, **p2** will be pointing to the **K**th to last element.

Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
Two iterations | O(n)                | O(1)
One iteration  | O(n)                | O(1)

- **n** - number of elements of the linked list.
