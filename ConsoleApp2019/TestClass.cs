using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2019
{
    public class TestClass
    {
        public void TestEvenOdd()
        {
            var dataevenodd = (123456).ToString();
            string lastvalue = dataevenodd.Substring(dataevenodd.Length - 1);
            List<int> Container = new List<int>() { 0, 2, 4, 6, 8};
            string ch = string.Empty;
            switch(lastvalue)
            {
                case "0":
                case "2":
                case "4":
                case "6":
                case "8":
                    Console.WriteLine("even");
                    break;
                default: Console.WriteLine("odd"); break;
            }

            if (Container.Contains(Convert.ToInt32(lastvalue)))
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("ODD");
        }
    }
}
