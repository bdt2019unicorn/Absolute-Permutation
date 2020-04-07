using System;

namespace Absolute_Permutation
{
    class Program
    {

        static int[] absolutePermutation(int n, int k)
        {
            int[] permutation = new int[n + 1]; 
            for (int i = 1; i <= n; i++)
            {
                permutation[i] = i; 
            }

            int[] fail = { -1 };

            for (int i = 1; i <= n; i++)
            {
                if(Math.Abs(permutation[i]-i)!=k)
                {
                    try
                    {
                        permutation[i + k] = i;
                        permutation[i] = i + k;
                    }
                    catch
                    {

                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (Math.Abs(permutation[i] - i) != k)
                {
                    return fail; 
                }
            }

            int[] final_result = new int[n];
            for (int i = 0; i < n; i++)
            {
                final_result[i] = permutation[i + 1];
            }

            return final_result; 
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32("10");
            string all_combination_n_k = @"10 0

                                            10 1

                                            7 0

                                            10 9

                                            9 0

                                            10 3

                                            8 2

                                            8 0

                                            7 0

                                            10 1
                                            ";
            string[] n_k_strings = all_combination_n_k.Split("\n\r", StringSplitOptions.RemoveEmptyEntries);

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = n_k_strings[tItr].Trim().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] result = absolutePermutation(n, k);

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
