namespace ParkingLotSystem
{
    public class CommandInvoker
    {
        private Stack<ICommand> _executedCommands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _executedCommands.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_executedCommands.Count > 0)
            {
                ICommand command = _executedCommands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }

}