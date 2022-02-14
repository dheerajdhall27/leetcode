
int[] TwoSum(int[] nums, int target)
{
    return TwoSumBruteForce(nums, target);
}

int[] TwoSumBruteForce(int[] nums, int target)
{
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

    return new int[] { -1, -1 };
}

int[] TwoSumHash(int[] nums, int target)
{
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

    return new int[] { -1, -1 };
}