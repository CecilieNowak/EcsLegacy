using System;

namespace ECSRefactored
{
    public class ECS
    {
        private int _threshold;
        
        public IHeater Heater { private get; set; } //Property injection
        public ITempSensor TempSensor { private get; set; } //Property injection
       

        public ECS(int thr)
        {
            SetThreshold(thr);
            TempSensor = new TempSensor();
            Heater = new Heater();
        }

        public void Regulate()
        {
            var t = TempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
                Heater.TurnOn();
            else
                Heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return TempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return TempSensor.RunSelfTest() && Heater.RunSelfTest();
        }
    }
}
