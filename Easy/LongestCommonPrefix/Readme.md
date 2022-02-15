# Longest Common Prefix

## Problem Statement

Write a method to find the longest common prefix string amongst array of strings

**Example:**<br/>
```
["flower", "flow", "flight"]
"fl"

["dog", "racecar", "car"]
""
```

1. One approach coul be to check the first character of all elements and then second etc.. till they are equal. We maintain a StringBuilder that we build one character at a time. A character is added to the StringBuilder if it's present in all the elements. As soon as the condition is not met we break and return.
```
var sb = new StringBuilder();

for (int i = 0; i < strs[0].Length; i++)
{
    char c = strs[0][i];

    bool completed = true;
    for (int j = 1; j < strs.Length; j++)
    {
        if (strs[j].Length - 1 < i)
        {
            completed = false;
            break;
        }
        if (c != strs[j][i])
        {
            completed = false;
            break;
        }
    }

    if(!completed)
    {
        break;
    }

    sb.Append(c);
}

return sb.ToString();
```