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
        public void ECS_TempSensorReturns22_HeaterTurnOn() //Vi tester om heateren tænder, hvis TempSensor returnerer 22
        {
            //arrange
            _fakeTempSensor.Temp = 22;

            //act
            _uut.Regulate();


            //assert
            Assert.That(_fakeHeater.TurnOnCounter, Is.EqualTo(1));

        }
    }
}