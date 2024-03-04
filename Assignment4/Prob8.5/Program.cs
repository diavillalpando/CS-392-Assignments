using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Prob8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string mystr = Console.ReadLine();
                Dictionary<char, int> seen = new Dictionary<char, int>();
                for (int i = 0; i < mystr.Length; i++)
                {
                    if (seen.ContainsKey(mystr[i]))
                    {
                        seen[mystr[i]] += 1;
                    }
                    else
                    {
                        seen[mystr[i]] = 1;
                    }
                }
                string x = String.Format("{0} appears most frequently in the string. Press any key to exit...", seen.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
                Console.WriteLine(x);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad Input. Press any key to exit...");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
