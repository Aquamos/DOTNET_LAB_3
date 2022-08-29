using LAB3.Data;
using LAB3.Models;

namespace LAB3.Console
{
    public class Printer
    {
        private ContextManager _contextManager;
        public Printer()
        {
            _contextManager = new ContextManager();
        }
        public void PrintRequests()
        {
            List<Document> documents = _contextManager.GetRequests();
            foreach (Document doc in documents)
            {
                System.Console.WriteLine(doc.ListParts());
            }
        }
        public void PrintDecrees()
        {
            List<Document> documents = _contextManager.GetDecrees();
            foreach (Document doc in documents)
            {
                System.Console.WriteLine(doc.ListParts());
            }
        }
        public void PrintOrders()
        {
            List<Document> documents = _contextManager.GetOrders();
            foreach (Document doc in documents)
            {
                System.Console.WriteLine(doc.ListParts());
            }
        }
        public void PrintLetters()
        {
            List<Document> documents = _contextManager.GetLetters();
            foreach (Document doc in documents)
            {
                System.Console.WriteLine(doc.ListParts());
            }
        }
    }
}
