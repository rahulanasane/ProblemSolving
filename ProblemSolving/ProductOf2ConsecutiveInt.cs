/*
 * Write a function solution that, given two integers A and B, return the number of integers from the range[A..B] (end are included) 
 * which can be expressed as the product of two consecutive integers, that X*(X+1), for some integer X.

Examples:

1.Given A = 6 and B = 20 the function should return 3.These integers are: 6 = 2 * 3, 12 = 3 * 4 and 20 = 4 * 5

2.Give A = 21 and B = 29, the function should return 0. There are no integers of the form X*(X+1) in this interval.
*/

using System;
namespace ProblemSolving
{
    public class ProductOf2ConsecutiveInt
    {
        private int int1;
        private int int2;

        public ProductOf2ConsecutiveInt()
        {
            this.int1 = 6;
            this.int2 = 20;

            Console.WriteLine(Solution(int1, int2));
        }

        public int Solution(int A, int B)
        {
            int start = (int)Math.Sqrt(A);
            int end = (int)Math.Sqrt(B);

            int first_m = start * (start + 1);
            int end_m = end * (end + 1);

            int iFirst = first_m >= A && first_m <= B ? 1 : 0;
            int iEnd = end_m >= A && end_m <= B ? 1 : 0;

            int result = end - start - 1 + iFirst + iEnd;

            return result >= 0 ? result : 0;

        }
    }
}
