using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var arr = new int[] { 5, -6, 9, -1, 2, -3, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
