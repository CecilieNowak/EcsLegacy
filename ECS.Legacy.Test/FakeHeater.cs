using System;
using System.Collections.Generic;
using System.Text;
using ECSRefactored;

namespace ECSRefactoredTest
{
   public class FakeHeater : IHeater

   {
       public int TurnOnCounter { get; set; }
       public int TurnOffCounter { get; set; }
        public void TurnOn()
        {
            System.Console.WriteLine("FakeHeater is on");
            TurnOnCounter++;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("FakeHeater is off");
            TurnOffCounter++;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
