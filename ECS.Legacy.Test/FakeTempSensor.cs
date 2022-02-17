using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored;

namespace ECS.Legacy.Test
{
   public class FakeTempSensor: ITempSensor

    {
        public int GetTemp()
        {
            return 20;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
