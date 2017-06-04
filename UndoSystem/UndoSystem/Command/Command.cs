namespace UndoSystem.Command
{
    public abstract class Command
    {
        protected Entity _entity;

        protected Command(Entity entity)
        {
            _entity = entity;
        }
        public void Execute()
        {
            CommandDispatcher.GetCommandDispatcher().Add(this);
            ExecuteCommand();
        }

        public abstract Command Clone();

        protected abstract void ExecuteCommand();
    }
}