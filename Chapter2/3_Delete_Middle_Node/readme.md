# Delete Middle Node

Given a element in the middle of a singly linked list, remove it from the list.

## Solution

### One iteration

As we don't have access to the element that point to the element to be removed, we can only change this element and following ones.

 * Copy the value of each of the following nodes to it's previous node 
 * Remove the last node by pointing the previous one to nil.

This can run in O(1) in the best case in the case that the last node is given. Actually this algorithm can't remove the last node, so the best case would be to remove the node before that. In the worst case the runtime is O(n) when the first node is given.

Solution       | Run-time Complexity | Space Complexity
-------------- | ------------------- | ----------------
One iteration  | O(n)                | O(1)

- **n** - number of elements of the linked list.