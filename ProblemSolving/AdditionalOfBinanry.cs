using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class AdditionalOfBinanry
    {
        private string binary1;
        private string binary2;

        public AdditionalOfBinanry()
        {
            this.binary1 = "11";
            this.binary2 = "1";

            Console.WriteLine(Add(binary1, binary2));

        }
        public string Add(string binary1, string binary2)
        {

            string result = ""; // Initialize result

            int s = 0; //Initialize digi sum

            int i = binary1.Length - 1;
            int j = binary2.Length - 1;

            while (i >= 0 || j >= 0 || s == 1)
            {

                s += ((i >= 0) ? binary1[i] - '0' : 0);
                s += ((j >= 0) ? binary2[j] - '0' : 0);

                result = (char)(s % 2 + '0') + result;

                s /= 2;

                i--;
                j--;


            }

            return result;
        }
    }

    
}
