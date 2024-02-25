
using System;

namespace Homeworktasks
{
    internal class CustomMash
    {
public int SumOffOddNumbers(int[] arr)
        {
            int sum=0; 
            foreach (var item in arr)
            {
                if (item % 2 == 1)
                {
                    sum += item;
                }
            }
            return sum;
        }


public void GetOddNums(int n)
        {
            if (n % 2 == 1)
            {
                Console.WriteLine("Tekdir");
            }
            else
            {
                Console.WriteLine("cutdur");
            }
        }

public int GetOddArrays(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum * sum;
        }

public int ArraysResult(int[] elems,int n)
        {
            int result = 1;
            
            for (int i = 1; i < elems.Length; i++)
            {
                if (elems[i] <= n)
                {
                    result *= elems[i];
                }
            }
            return result;
            
        }


    }


}
