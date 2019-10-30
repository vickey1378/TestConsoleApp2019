using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2019
{
      class Program
    {
        int x, y;

       HangoutData ds = new HangoutData();
         static Program()
        {

        }
         public  Program(int x ,int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine(this.x);
            Console.WriteLine(this.y);
        }

        static void Main(string[] args)
        {
            //Program p1 =new Program(10, 20);
            //p1.LoadJson();
            TestClass testClass = new TestClass();
            testClass.TestEvenOdd();
            Console.ReadKey();
        }
        public  void LoadJson()
        {
            using (StreamReader r = new StreamReader(@"E:\Hangouts.json"))
            {
                string json = r.ReadToEnd();
                ds  = JsonConvert.DeserializeObject<HangoutData>(json);
            }
        }
    }
}
