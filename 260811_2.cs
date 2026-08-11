using System;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        int[] lastPos = new int[26];

        for (int i = 0; i < 26; i++)
        {
            lastPos[i] = -1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            int alphabetIndex = s[i] - 'a';

            if (lastPos[alphabetIndex] == -1)
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - lastPos[alphabetIndex];
            }
            lastPos[alphabetIndex] = i;
        }
        return answer;
    }
}