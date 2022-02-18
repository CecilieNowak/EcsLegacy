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
        public void GetThresholdMethod_ThresholdIs23_MethodReturns23() //Vi tester her om metoden returnerer 23, hvis threshold er sat til 23
        {
            //arrange - arrange sker i setup linje 17. Her sættes threshold til 23

            //act
            var testThreshold = _uut.GetThreshold();

            //assert
            Assert.That(testThreshold, Is.EqualTo(23));

        }
    }
}