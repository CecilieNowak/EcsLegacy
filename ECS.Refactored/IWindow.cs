using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored
{
    public interface IWindow
    {
        public void Open();
        public void Close();
        public bool RunSelfTest();
    }
}
