using NUnit.Framework;
using UndoSystem.Command;

namespace UndoSystem.Tests
{
    [TestFixture]
    public class ComandTests
    {
        private Entity _entity;
        [SetUp]
        public void SetUp()
        {
            _entity = new Entity()
            {
                Value = 0
            };
        }

        [Test]
        public void IncrementCommandTest()
        {
            _entity.Increment();
            _entity.Increment();

            Assert.AreEqual(2, _entity.Value);
        }

        [Test]
        public void DecrementCommandTest()
        {
            _entity.Decrement();
            _entity.Decrement();

            Assert.AreEqual(-2, _entity.Value);
        }

        [Test]
        public void IncrementThenDecrementCommandTest()
        {
            _entity.Increment();
            _entity.Increment();
            _entity.Decrement();
            _entity.Decrement();

            Assert.AreEqual(0, _entity.Value);
        }
    }
}
