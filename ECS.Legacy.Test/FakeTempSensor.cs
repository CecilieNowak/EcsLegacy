using System;
using System.Collections.Generic;
using System.Text;
using ECSRefactored;

namespace ECSRefactoredTest
{
   public class FakeTempSensor : ITempSensor
   {
       public int Temp { get; set; }
        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
