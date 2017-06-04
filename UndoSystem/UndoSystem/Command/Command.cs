namespace UndoSystem.Command
{
    public abstract class Command
    {
        protected Entity _entity;
        private readonly CommandDispatcher _dispatcher;

        protected Command(Entity entity)
        {
            _entity = entity;
            _dispatcher = CommandDispatcher.GetCommandDispatcher();
        }
        public void Execute()
        {
            _dispatcher.Add(this);
            ExecuteCommand();
        }

        public abstract Command Clone();

        protected abstract void ExecuteCommand();
    }
}