using System;

public class CyclicRotation
{
    int[] solution(int[] A, int K)
    {
        if (A == null || A.Length == 0) return A;

        var result = new int[A.Length];

        int startIndex = A.Length - K % A.Length;

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = A[(startIndex + i) % A.Length];
        }

        return result;
    }
}
