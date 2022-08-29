using LAB3.Enums;
using LAB3.Models;
using LAB3.Data;

namespace LAB3.Builder
{
    public class DocumentBuilder : IDocumentBuilder
    {
        private Context _context = Context.GetContext();
        private Document _doc = new Document();
        public DocumentBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._doc = new Document();
        }
        public void AddDocumentToContext() 
        {
            Document resDoc = this._doc;
            this.Reset();
            _context.Documents.Add(resDoc);
        }
        public void AddType(Types type)
        {
            this._doc.Type = type;
        }
        public void AddState(DocumentStates ds)
        {
            this._doc.documentState = ds;
        }
        public void AddNumber()
        {
            this._doc.Add((_context.Documents.Count()+1).ToString());
        }
        public void AddDate()
        {
            this._doc.Add(DateTime.Now.ToShortDateString());
        }
        public void AddContent(string content)
        {
            this._doc.Add(content);
        }
        public void AddCorrespondent(string correspondent)
        {
            this._doc.Add(correspondent);
        }
        public void AddClassificationLevel(СlassificationLevels cl)
        {
            this._doc.Add(cl.ToString());
        }
        public void AddDocumentState(DocumentStates ds)
        {
            this._doc.Add(ds.ToString());
        }
        public void AddUnit(Units unit)
        {
            this._doc.Add(unit.ToString());
        }
        public void AddDeadline(DateTime deadline)
        {
            this._doc.Add(deadline.ToShortDateString());
        }
        public void AddExecutor(string executor)
        {
            this._doc.Add(executor);
        }
        public void AddRequester(string requester)
        {
            this._doc.Add(requester.ToString());
        }
        public void AddResources(string resources)
        {
            this._doc.Add(resources.ToString());
        }
    }
}
