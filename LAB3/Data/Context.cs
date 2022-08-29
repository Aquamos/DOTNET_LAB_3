using LAB3.Models;

namespace LAB3.Data
{
    public sealed class Context
    {
        private static Context _context;
        private Context()
        {
            Documents = new List<Document>();
        }
        public static Context GetContext()
        {
            if (_context == null)
            {
                _context = new Context();
            }
            return _context;
        }

        public List<Document> Documents { get; set; }
    }
}
