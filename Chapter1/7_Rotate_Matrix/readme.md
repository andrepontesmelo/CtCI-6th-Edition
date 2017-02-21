# Rotate Matrix

Given an image represented by an **NxN** matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place ?

# Solution

## Using additional O(N^2) space

Given a pair of coordinates **(i, j)** we can map it no new coordinates, that would be **(j, N-i-1)**. Using additional space is straight forward: we iterate over all items of the matrix copying the values for the new location using the formula above.

## Using constant space

For each position in the matrix, we need to perform 4 swaps in order to get back to start position. We can use a queue to store the temporary values during the swap. As the queue will never hold more then 4 values the solution will continue to be O(1) in terms of space complexity. Let's assume we have a 4x4 matrix **M**. Then the first position is (0,0). The other three positions that will be swapped are: (0, 3), (3,0), (3, 3). One loop over those coordinates would store their matrix values to the queue, and a second iteration would pop from queue and set to the final position. Alternatively, we can do this process in one iteration instead of two, and only store two values in the queue as listed below:

```
push to queue M[0,0]

# Iteration 1
push to queue M[0,3]
M[0,3] = queue pop # M[0, 0]

# Iteration 2
push to queue M[3,0]
M[3,0] = queue pop # M[0, 3]

# Iteration 3
push to queue M[3,3]
M[3,3] = queue pop # M[3, 0]

# Iteration 4
push to queue M[0,0] # Will not be used
M[0, 0] = queue pop # M[3, 3]
```

Let's call the above procedure *rotate(pos)*, where the initial position (0,0) was passed as an argument. One call to this procedure fixes the matrix for 4 values. So we need to make sure we will not call this procedure for some position that was already fixed by another call. The  algorithm still needs to touch all the elements of the matrix, so the complexity is O(N^2).

Solution                 | Run-time Complexity | Space Complexity
------------------------ | ------------------- | ----------------
Using additional space   | O(N^2)              | O(N^2)
Without additional space | O(N^2)              | O(1)
