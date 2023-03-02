using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RomanToIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var x = p.RomanToInteger("MCMXCIV");
            var x = p.RomanToInteger("LVIII");
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public  string RomanToInteger(string str)
        {

            int value = 0;
            char[] chars = str.ToCharArray();
            var resultValues = chars.Select(x => x.RN()).ToArray<int>();
            int[] ints = new int[chars.Length];
            for(int i=0;i< resultValues.Length-1;i++)
            {
                if (resultValues[i] >= resultValues[i + 1])
                {
                    ints[i]=resultValues[i];
                }
                else
                {
                    ints[i] = (resultValues[i]*-1);
                }
            }
            ints[chars.Length-1] = resultValues[chars.Length-1];
            for(int i=0;i<chars.Length;i++)
            {
                value += ints[i];
            }     
            return value.ToString();        
            
        }

     



    }
}
