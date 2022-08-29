using LAB3.Models;
using LAB3.Enums;

namespace LAB3.Data
{
    public class ContextManager
    {
        private readonly Context _context;
        public ContextManager()
        {
            _context = Context.GetContext();
        }
        public List<Document> GetRequests()
        {
            return _context.Documents.Where(x => x.Type == Types.Request).ToList();
        }
        public List<Document> GetDecrees()
        {
            return _context.Documents.Where(x => x.Type == Types.Decree).ToList();
        }
        public List<Document> GetOrders()
        {
            return _context.Documents.Where(x => x.Type == Types.Order).ToList();
        }
        public List<Document> GetLetters()
        {
            return _context.Documents.Where(x => x.Type == Types.Letter).ToList();
        }
    }
}
