# Zero Matrix

Write an algorithm such that if an element is in an MxN matrix is 0, its entire row and column are set to 0.

# Solutions

We need to iterate over the matrix twice: first to find out what rows and lines need to be cleaned, and the second to actually set their values to zero. How can we find out what are the lines and rows that needs to be cleaned ?

# Using additional memory

We can allocate two bit arrays: one for horizontal and other for vertical that will be a flag for cleanup. We can initialise those arrays with '1'. We then iterate over all elements of matrix, changing it to:

```
horizontal_flag[i] &= M[i][j] != 0
vertical_flag[j] &= M[i][j] != 0
```

An optimization would be to jump to next line when the horizontal flag becomes zero.

# Without using additional memory

We can use the first line and first row of the matrix be our flag arrays. But instead of dealing with a flag array that contains ones and zeros, our array will contain:

```
M[0][j] =
   0                  if any of the values in column j are zero.
   original M[0][j]   otherwise

 M[i][0] =
    0                  if any of the values in row i are zero.
    original M[i][0]   otherwise
```

Then we iterate over all elements of matrix with exception of first row and first column in order to check
their values, and set the their associated flag accordingly.

Then we iterate the matrix over again to set the zeros.

We still need to zero first column and first row if necessary.
So we can iterate over those arrays to check if the clean is necessary, and iterate over again in order to
clean them.

Solution                        | Run-time Complexity | Space Complexity
------------------------------- | ------------------- | ----------------
Using additional memory         | O(N^M)              | O(max(N, M))
Without using additional memory | O(N^M)              | O(1)
