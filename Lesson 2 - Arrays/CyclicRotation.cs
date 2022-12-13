using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int[] solution(int[] A, int K) {
        
        // If we have no elements in our array, return it.
        if(A.Length == 0)
        {
            return A;
        }

        int numOfIterations = 0;

        // Rotate our array by K iterations.
        while(numOfIterations < K)
        {
            RotateArrayRight(ref A);
            numOfIterations++;
        }

        return A;
    }

    private void RotateArrayRight(ref int [] array)
    {
        // The last element will always be shifted to the front.
        int lastElement = array[array.Length - 1];

        // Take a sub-section of our array without the last element.
        List<int> subArray = array.Take(array.Length - 1).ToList<int>();

        // Insert the last element at the front of the list.
        subArray.Insert(0, lastElement);

        array = subArray.ToArray();
    }
}
