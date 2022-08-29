using static System.Console;


namespace LAB3.Menu
{
    public class MenuController
    {
        private readonly CommandsDictionary _commandsDictionary;
        private readonly MenuSeeder _menuSeeder;
        private int _selectedIndex;
        public MenuController() 
        {
            _commandsDictionary = new CommandsDictionary();
            _menuSeeder = new MenuSeeder();
        }
        public void Run()
        {
            while (true)
            {
                _selectedIndex = _menuSeeder.Menu.Run();
                if (_selectedIndex != -1)
                {
                    InvokeMenuCommand();
                }
            }
        }
        private void InvokeMenuCommand()
        {
            Clear();
            _commandsDictionary[(MenuCommands)_selectedIndex].Invoke();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
        }
    }
}
