using System.Text;

string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0)
    {
        return "";
    }

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
}