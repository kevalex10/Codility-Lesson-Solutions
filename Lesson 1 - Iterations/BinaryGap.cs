using System;

class Solution {
    public int solution(int N) 
    {
        // Get a string of bits from the integer.
        string bits = Convert.ToString(N, 2);

        int largestGap = 0;
        int gapCount = 0;

        bool beginCount = false;

        // Loop through the bits
        foreach(char c in bits)
        {
            // If the current bit is a 1, begin counting when the next bit is a 0.
            if(c != '0')
            {
                // We already began counting last iteration and the current bit is a 1.
                if(beginCount)
                {
                    // Check if the count was larger than the record.
                    if(gapCount > largestGap)
                    {
                        largestGap = gapCount;
                    }

                    // Reset the counter.
                    gapCount = 0;
                }

                beginCount = true;
            }
            else
            {
                if(beginCount)
                {
                    gapCount++;
                }
            }
        }

        return largestGap;
    }
}
