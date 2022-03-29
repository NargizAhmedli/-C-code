using System;
using System.Collections.Generic;
using System.Text;

namespace _28032022_task_2
{
    internal static class TextExtension
    {
        public static bool IsOdd(this int num)
        {
            if(num%2==1)
                return true;  
            
            return false;   
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;

            return false ;
        }
        
        public static bool IsContainsDigit(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsDigit(item))
                        return true;
                   
                }
                return false;
            }

        }

        public static void ToCapitalize(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.ToCapitalize(item))
                        return true;
                }
                return false;
            }
        }
        public static void GetValueIndexes[] getValueIndexes;
        public GetValueIndexes(int arr)
        {
            getValueIndexes  = new GetValueIndexes[0]
        }
    }
}
