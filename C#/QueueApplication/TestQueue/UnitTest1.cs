namespace TestQueue
{
    public Class Tests
        {

        [SetUp]
        Public void Setup()
        {
        }

        [Test]
        Public void Test1()
            {
                Assert.Pass();
            }
        [Test]
        Public void TestEqueue()
            {
            IntegerQueue myQueue = New IntegerQueue();

            myQueue.Enqueue(12345);
            Int myCount = myQueue.Count;

            Assert.That(myCount, Is.EqualTo(1));

            Assert.That(myQueue._element.Count, Is.EqualTo(1));
            Assert.That(myQueue._element[0], Is.EqualTo(12345));
            }

        [Test]
        Public void TestDequeue()
            {
           Assert.Fail 
        }
    }

}