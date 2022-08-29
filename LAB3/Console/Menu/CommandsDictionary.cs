using LAB3.Console;

namespace LAB3.Menu
{
    public class CommandsDictionary
    {
        private Printer _printer;
        private DocumentCreator _documentCreator;

        private Dictionary<MenuCommands, Action> _menuCommands;

        public CommandsDictionary() {

            _printer = new Printer();
            _documentCreator = new DocumentCreator();

            _menuCommands = new Dictionary<MenuCommands, Action>()
            {
                {MenuCommands.GetRequests, _printer.PrintRequests },
                {MenuCommands.GetDecrees, _printer.PrintDecrees },
                {MenuCommands.GetOrders, _printer.PrintOrders },
                {MenuCommands.GetLetters, _printer.PrintLetters },

                {MenuCommands.CreateRequest, _documentCreator.CreateRequest },
                {MenuCommands.CreateDecree, _documentCreator.CreateDecree },
                {MenuCommands.CreateOrder, _documentCreator.CreateOrder},
                {MenuCommands.CreateLetter, _documentCreator.CreateLetter},
            };

        }
        public Action this[MenuCommands index] => _menuCommands[index];


    }
}
