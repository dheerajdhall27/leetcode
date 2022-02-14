# Two Sum

One of the most asked beginner level interview question. The problem is easily solvable by using brute force. But, the optimization that they look for is the use of a Hashtable.

---

## Problem Statement
Given an **array of integers** and a **target** value return the indices of the values that add to the **target**


1. The easiest solution is to use the brute force approach with two a nested loop and compare each index with the others to find the values that add to the target which would look something like this. We do not compare the index that we have seen already (Once 0th index is seen it's not compared again)

```
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target)
        {
            return new int[] { i, j };
        }
    }
}
```

**Time Complexity :** O(n<sup>2</sup>)<br/>
**Space Complexity:** O(1);

<br/>
<br/>

2. An optimization to the above solution would be to use a **Hashtable** to the store the values that have been seen and check for the difference between target and the current value and if that exists in the Hashtable

The solution would something like
```
var dict = new Dictionary<int, int>();

for (int i = 0; i < nums.Length; i++)
{
    int difference = target - nums[i];

    if (dict.ContainsKey(difference))
    {
        return new int[] { dict[difference], i };
    }

    if (!dict.ContainsKey(nums[i]))
    {
        dict.Add(nums[i], i);
    }
}
```

**Time Complexity :** O(n)<br/>
**Space Complexity:** O(n)