using System;
using System.Collections.Generic;
using System.Linq;
static class PalindromeProducts
{
    static bool IsPalindrome(int value)
    {
        int orig = value;
        int rev = 0;
        while (value != 0)
        {
            rev = rev*10 + value%10;
            value /= 10;
        }
        return rev == orig;
    }
    static (int, (int, int)[]) FindPalindrome(int lowerBound, int upperBound, int initVal, Func<int, int, bool> compareFunc)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException();
        int value = initVal;
        List<(int, int)> factors = new List<(int, int)>();
        for (int i = lowerBound; i <= upperBound; i++)
        {
            for (int j = i; j <= upperBound; j++)
            {
                int attempt = i*j;
                if (compareFunc(attempt, value) && IsPalindrome(attempt))
                {
                    value = i*j;
                    factors.Clear();
                }
                if (attempt == value)
                {
                    factors.Add((i, j));
                }
            }
        }
        if (!factors.Any())
            throw new ArgumentException();
        return (value, factors.ToArray());
    }
    public static (int, (int, int)[]) Largest(int lowerBound, int upperBound) => FindPalindrome(lowerBound, upperBound, 0, (a, b) => a > b);
    public static (int, (int, int)[]) Smallest(int lowerBound, int upperBound) => FindPalindrome(lowerBound, upperBound, int.MaxValue, (a, b) => a < b);
}