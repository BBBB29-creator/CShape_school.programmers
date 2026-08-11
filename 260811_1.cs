using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        int len_p = p.Length;
        int len_t = t.Length;

        long num_p = long.Parse(p);

        for (int i = 0; i <= len_t - len_p; i++)
        {
            string subStr = t.Substring(i, len_p);

            if (long.Parse(subStr) <= num_p)
                answer++;
        }
        return answer;
    }
}