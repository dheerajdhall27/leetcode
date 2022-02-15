
bool IsPalindrome(int x)
{
    return true;
}

bool IsPalindromeReversedString(int x)
{

    string num = x.ToString();

    char[] numCharArray = num.ToCharArray();

    Array.Reverse(numCharArray);

    string reversed = new String(numCharArray);

    return num.Equals(reversed);
}

bool IsPalindromeUsingString(int x)
{
    string num = x.ToString();

    int left = 0;
    int right = num.Length - 1;

    while (left <= right)
    {
        if (num[left] != num[right])
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}