using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored
{
    public class Window : IWindow
    {
        public void Open()
        {
            System.Console.WriteLine("Open window");
        }

        public void Close()
        {
            System.Console.WriteLine("Close window");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
