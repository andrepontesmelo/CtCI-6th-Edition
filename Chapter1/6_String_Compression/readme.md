# String Compression

Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabcccccaaa would became a2b1c5a3\. If the "compressed" string would not become smaller then the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z).

## Linear Solution

Just iterate over the input string and write the compressed string. In the end, return the compressed one only if it is smaller then the original.

Solution | Run-time Complexity | Space Complexity
-------- | ------------------- | ----------------
Linear   | O(n)                | O(n)

- **n** - Length of input string.

## Implementation details

For this problem, we need a fast way to append a string within a loop as discussed in [this thread](http://stackoverflow.com/questions/42332469/what-is-the-fastest-way-to-increment-a-string-in-perl). Three different methods were tested:

- Join: Keep the compressed output as string, and call join foreach iteration to append the substring.
- List: Keep the compressed output as list, and append new elements either being a single character or a compressed chunk.
- Concat: Keep the compressed output as string, and do a regular string concat foreach operation ($compressed .= compress_chunk(...));

### Results

The regular perl concat variation performed better then other approaches as listed bellow.

```
Rate   join   list concat
join   62.5/s     --   -34%   -36%
list   94.0/s    50%     --    -3%
concat 97.0/s    55%     3%     --
[Finished in 18.707s]
```
