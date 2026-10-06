using CouterTask;
using System.Diagnostics.Metrics;

namespace Clocktest
{
    public class Tests
    {
        private Counter _counter;
        [SetUp]
        public void Setup()
        {
            _counter = new Counter("Test1");
        }

        [Test]

        public void InitialCounterTest()
        {
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }
        [Test]
        public void Test1()
        {
            _counter.Increment();
            Assert.That(_counter.Ticks, Is.EqualTo(1));
           
        }
        [Test]
        public void Test2() 
        {
            for (int i = 0; i < 12; i++)
            {
                _counter.Increment();
            }
            Assert.That(_counter.Ticks, Is.EqualTo(12));
        }
        [Test]
        public void Test3()
        {
            for (int i = 0; i < 12; i++)
            {
                _counter.Increment();
            }
            _counter.Reset();
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }
    }
}