
using NUnit.Framework;
using UndoSystem.Command;

namespace UndoSystem.Tests
{
    [TestFixture]
    public class UndoTests
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
        public void UndoTest1()
        {
            var commandDispatcher = CommandDispatcher.GetCommandDispatcher();

            commandDispatcher.SaveState(_entity.CreateMemento());

            _entity.Increment();
            _entity.Increment();
            _entity.Increment();

            commandDispatcher.Undo();

            Assert.AreEqual(2, _entity.Value);
        }

        [Test]
        public void UndoTest2()
        {
            var commandDispatcher = CommandDispatcher.GetCommandDispatcher();

            commandDispatcher.SaveState(_entity.CreateMemento());

            _entity.Increment();
            _entity.Increment();
            _entity.Increment();

            _entity.Decrement();
            _entity.Decrement();
            _entity.Decrement();

            commandDispatcher.Undo();
            commandDispatcher.Undo();

            Assert.AreEqual(2, _entity.Value);
        }
    }
}
