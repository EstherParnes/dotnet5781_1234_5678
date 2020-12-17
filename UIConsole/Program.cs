using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BO;

namespace UIConsole
{
   class Program
   {
      //static BL.MyBL b1 = new BL.MyBL();
      static IBL bl = BLFActory.GetBL();
         static void Main(string[] args)
      {
         Console.Write("Please enter how many days back: ");
         int days = int.Parse(Console.ReadLine());
         for (int d = days; d >= 0; --d)
         {
            Weather w = bl.GetWeather(d);
            Console.WriteLine($"{d} days before - Feeling was: {w.Feeling} Celsius degrees");
         }

         //Console.WriteLine(b1.getResult());
      }
   }
}
