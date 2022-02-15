# Palindrome Number

Checking if a number is a palindrome involves reversing the number and comparing the reveresed number with the original number and make sure they equate.

**Example:**<br/>
```
121
true

123322
false
```

## Problem Statement
Give an integer, return *true* if the number is a palindrome

1. The First solution that would come to mind is to convert the integer to a string and then reverse that string and compare with the original. It would look something like this
```
string num = x.ToString();

char[] numCharArray = num.ToCharArray();

Array.Reverse(numCharArray);

string reversed = new String(numCharArray);

return num.Equals(reversed);
```

**Time Complexity :** O(n)<br/>
**Space Complexity:** O(1);

2. An improvement to the above solution can be to use a two pointer technique after converting the string to a *char* array. The idea is to compare characters from both ends and make sure they match. It would look something like this.
```
string num = x.ToString();
        
char[] numCharArray = num.ToCharArray();

int left = 0;
int right = numCharArray.Length - 1;

while(left <= right)
{
    if(numCharArray[left] != numCharArray[right])
    {
        return false;
    }
    
    left++;
    right--;
}

return true;
```

**Time Complexity :** O(n)<br/>
**Space Complexity:** O(1);

3. The solution on leetcode is quite elegant. Only half of the number is reverted and compared with the other half.