int RomanToInt(string s)
{
    int value = 0;
    for (int i = 0; i < s.Length; i++)
    {
        value += GetNumber(s, i);
    }

    return value;
}

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