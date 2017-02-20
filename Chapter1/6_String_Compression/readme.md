# String Compression

Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabcccccaaa would became a2b1c5a3\. If the "compressed" string would not become smaller then the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z).

## Linear Solution

Just iterate over the input string and write the compressed string.
In the end, return the compressed one only if it is smaller then the original.

Solution | Run-time Complexity | Space Complexity
-------- | ------------------- | ----------------
Linear   | O(n)                | O(n)

 * **n** - Length of input string.
