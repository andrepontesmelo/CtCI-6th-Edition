# String Rotation

Assume you have a method isSubstring which checks if one word is a substring of another. Given two string, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring eg., "waterbottle" is a rotation of "erbottlewat".

## Solution

One string is a rotation of another if and only if their lengths are the same. If that's the case, then just need to check if one string in a substring of the other string duplicated.

- waterbottle is a substring of erbottle**watebottle**wat
- erbottlewat is a substring of wat**erbottlewat**erbottle

Then we just need to result if isSubstring(s1, s2 . s2) != -1. The runtime complexity depends on isSubstring. If it's inner implementation do a linear search over the string, then runtime complexity would be O(n) where n is the length of both strings.

Solution | Run-time Complexity | Space Complexity
-------- | ------------------- | ----------------
Linear   | O(n)                | O(1)

- **n** - length of string s2. -
