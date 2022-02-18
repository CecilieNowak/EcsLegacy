using System;
using System.Collections.Generic;
using System.Text;

namespace ECSRefactored
{
    public interface IHeater
    {
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}
