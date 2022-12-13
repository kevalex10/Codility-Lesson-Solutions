using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) 
    {
        var hashSet = new HashSet<int>();

        // Loop through all the numbers at least once.
        foreach(int i in A)
        {
            // Cross check them against a hash set.
            if(!hashSet.Contains(i))
            {
                hashSet.Add(i);
            }
            else
            {
                hashSet.Remove(i);
            }
        }
		
        // The only remaining number will be the odd one out.
        foreach(int i in hashSet)
        {
            return i;
        }

		return 0;
    }
}
