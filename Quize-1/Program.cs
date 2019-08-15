using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1,2, 3, 4, 5, 6};
            var result = GetUniqueElement(array);
            var resultOfDuplicate = IsContainDubplicateEelement(array);
            var resultOfSet = UsingSetForDuplicate(array);
            Console.WriteLine(resultOfSet);
            Console.WriteLine(resultOfDuplicate);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool IsContainDubplicateEelement(int[] arr)
        {


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int GetUniqueElement(int[] arr)
        {
            //var array = arr;
            //Console.WriteLine(arr[0]);

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(i!=j && arr[i] == arr[j])
                    {
                        break;
                    }
                    if (j == arr.Length-1)
                    {
                        return arr[i];
                    }
                }
            }
            return 0;
        }
        
        public static bool UsingSetForDuplicate(int[] arr)
        {

            HashSet<int> set = new HashSet<int>(arr);
            if (arr.Length != set.Count())
                return false;

            return true;            
        }
    }
}
