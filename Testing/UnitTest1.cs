using System;
using Xunit;
using System.Linq;
namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] elements = new int[]{1,2,3,4,5,6 };
            int[] bin = new int[elements.Length];
            int[] answer = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                //Convert int to binary
                string result
                   = Convert.ToString(elements[i], 2);
                //Count occurance of 1
                int count = 0;
                foreach (char c in result)
                {
                    if (c == '1')
                    {
                        count += 1;
                    }
                }
                bin[i] = (int)count;
                answer[i] = elements[i];

            }
            //sort array
            Array.Sort(bin, answer);
        }
    }
}
