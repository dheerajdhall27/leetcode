# Roman To Integer

The Scope of this problem is limited to numbers [1, 3999]. This implies that that number fomed would use the following characters<br/>
`I | V | X | L | C | D | M`

**Example:**
```
"MCMXCIV"
1994
```

## Problem Statement

Given a string representing a Roman numeral, convert it to an integer. Numbers are between 1 and 3999.

1. Roman numeral can be broken down from left to right, where each character represents an integer with the exception of `5,10, 50, 100, 500 and 100`. When these character are preceded by 1 multiplied by the `Units, Units, Tens, Tens, Hundreds and Hudreds` respectively.

**For example** <br/>
When the Roman Numeral is `III` it represents a **3** <br/>
But when the Roman Numeral needs to be **4** which is one number before the numberin the list it is represented as `IV`.

So, to solve the problem we would maintain an **integer** which would initially hold the value **0** and then as we move from left to right we keep adding the value of the numeral to the **integer**.

When solving for `IV`<br/>
1. First char is `I` so the integer would hold **1**
2. Second char is `V` since the preceding char is a `I` and by the rule above the units match then these two character need to be combined to form a 4. Since we already had 1 as the **integer** value, it now becomes 4 and that is our answer

The Algorithm would look something like.
```
int GetNumber(string s, int currentIndex)
{
    switch (s[currentIndex])
    {
        case 'I':
            return 1;
        case 'V':
            if (currentIndex > 0 && s[currentIndex - 1] == 'I')
            {
                return 3;
            }
            return 5;
        case 'X':
            if (currentIndex > 0 && s[currentIndex - 1] == 'I')
            {
                return 8;
            }
            return 10;
        case 'L':
            if (currentIndex > 0 && s[currentIndex - 1] == 'X')
            {
                return 30;
            }
            return 50;
        case 'C':
            if (currentIndex > 0 && s[currentIndex - 1] == 'X')
            {
                return 80;
            }
            return 100;
        case 'D':
            if (currentIndex > 0 && s[currentIndex - 1] == 'C')
            {
                return 300;
            }
            return 500;
        case 'M':
            if (currentIndex > 0 && s[currentIndex - 1] == 'C')
            {
                return 800;
            }
            return 1000;
        default:
            return 0;
    }
}
```