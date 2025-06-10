//*****************************************************************************
//** 3442. Maximum Difference Between Even and Odd Frequency I      leetcode **
//*****************************************************************************

int maxDifference(char* s) {
    int freq[26] = {0};

    for (int i = 0; s[i] != '\0'; i++)
    {
        freq[s[i] - 'a']++;
    }

    int maxDiff = -100;

    for (int i = 0; i < 26; i++)
    {
        if (freq[i] % 2 == 1)
        {
            for (int j = 0; j < 26; j++)
            {
                if (freq[j] % 2 == 0 && freq[j] > 0)
                {
                    int diff = freq[i] - freq[j];
//                    printf("%d\n",diff);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
        }
    }

    return maxDiff;
}