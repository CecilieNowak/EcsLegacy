using NUnit.Framework;
using ECSRefactored;

namespace ECSRefactoredTest
{
    [TestFixture]
    public class Tests
    {
        private ECS _uut;
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;

        [SetUp]

        public void Setup()
        {
            _uut = new ECS(23);

            _fakeTempSensor = new FakeTempSensor();
            _uut.TempSensor = _fakeTempSensor;

            _fakeHeater = new FakeHeater();
            _uut.Heater = _fakeHeater;

        }

        //Navn til testmetode: [UnitOfWorkName]_[ScenarioUnderTest]_[ExpectedBehavior]
        [Test]
        public void RegulateMethod_TempSensorReturns22_HeaterTurnOn() //Vi tester om heateren tænder, hvis TempSensor returnerer 22
        {
            //arrange
            _fakeTempSensor.Temp = 22;

            //act
            _uut.Regulate();


            //assert
            Assert.That(_fakeHeater.TurnOnCounter, Is.EqualTo(1));

        }

        [Test]
        public void SetThresholdMethod_ThresholdIsSetTo14_GetThresholdMethodReturns14() //Vi tester om threshold bliver sat til 14, ved brug af Get-metoden (da threshold er en privat variabel, og ikke en property)
        {
            //arrange
            _uut.SetThreshold(14);

            //act
            var testThreshold = _uut.GetThreshold();

            //assert
            Assert.That(testThreshold, Is.EqualTo(14));
        }

        [Test]
        public void GetThresholdMethod_ThresholdIs23_MethodReturns23() //Vi tester her om metoden returnerer 23, hvis threshold er sat til 23
        {
            //arrange - arrange sker i setup linje 17. Her sættes threshold til 23

            //act
            var testThreshold = _uut.GetThreshold();

            //assert
            Assert.That(testThreshold, Is.EqualTo(23));

        }

        [Test]
        public void RunSelfTestMethod_MethodReturnsTrue() //Vi tester her om metoden returnerer true
        {
            //arrange - sker i setup linje 17.

            var testRunSelfTest = _uut.RunSelfTest();

            Assert.That(testRunSelfTest, Is.True);
        }

        [Test]
        public void RegulateMethod_TempSensorReturns23_HeaterTurnOff()
        {
            //arrange
            _fakeTempSensor.Temp = 23;
           

            //act
            _uut.Regulate();


            //assert
            Assert.That(_fakeHeater.TurnOffCounter, Is.EqualTo(1));
        }

    }
}