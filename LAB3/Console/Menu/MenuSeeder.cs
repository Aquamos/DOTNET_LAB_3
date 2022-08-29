

namespace LAB3.Menu
{
    public class MenuSeeder
    {
        public Menu Menu { get; set; }
        public MenuSeeder()
        {
            Menu = new Menu()
            {
                Header = "Welcome to the LAB3. What would you like to do?",
                Options = new string[]
                {
                   "Get requests",
                   "Get decrees",
                   "Get orders",
                   "Get letters",
                   "Create request",
                   "Create decree",
                   "Create order",
                   "Create letter"
                }
            };
        }
    }
}
