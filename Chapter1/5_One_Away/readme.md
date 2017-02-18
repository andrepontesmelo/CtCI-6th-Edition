# One Away

There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character.
Given two strings, write a function to check if they are one edit (or zero edits) away.

## Solution

### Linear

 We can immediately finish the algorithm in this special case: if the difference of the length of input strings is greater then 1, then we would need more then one inserts (or removes). Therefore we return false.

 Let's look at the 3 operations separately

 **Replace** In the case that the length of both strings are the same, the operation can only be *replace*. It cannot be *remove* neither *insert*. We can verify if there is only one replace operation by iterating over both strings and check how many characters differ. A *replace* operation could have been performed if and only if this difference is one.

 **Insert or Remove** Insert and remove are equivalent somehow: if an *insert* operation is made to turn **a** into **b**, this is the same of performing a *remove* operation to turn **b** into **a**. We can iterate over both strings comparing each character. When it differs for the first time, we can move forward the index of the smaller string in one position in order to simulate an insert operation. Then, the next iteration will continue to compare the strings. There will be only one *insert/remove* operation performed if and only if this insert simulation happened only once.


Solution    | Run-time Complexity | Space Complexity
----------- | ------------------ | ----------------
Linear      | O(n)               | O(1)

- **n** - length of biggest string
