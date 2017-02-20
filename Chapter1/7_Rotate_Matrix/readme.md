# Rotate Matrix

Given an image representated by an **NxN** matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place ?

# Solution

## Using additional space

Given a pair of coordinates **(i, j)** we can map it no new coordinates,
that would be **(j, N-i-1)**. Using additional space is straigth forward: we iterate over
all items of the matrix copying the values for the new location using the formula above.

Solution               | Run-time Complexity | Space Complexity
---------------------- | ------------------- | ----------------
Using additional space | O(N^2)              | O(N^2)
