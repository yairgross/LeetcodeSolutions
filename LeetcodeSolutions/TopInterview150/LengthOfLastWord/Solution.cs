namespace TopInterview150.LengthOfLastWord;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int len = 0;
        int i = s.Length - 1;
        bool foundWord = false;

        while (i >= 0)
        {
            if (s[i] == ' ')
            {
                if (foundWord)
                    return len;
            }

            else
            {
                foundWord = true;
                len++;
            }

            i--;
        }

        return len;
    }
}
