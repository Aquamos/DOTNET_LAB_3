using LAB3.Enums;

namespace LAB3.Builder
{
    public interface IDocumentBuilder
    {
        public void AddDocumentToContext();
        public void AddType(Types type);
        public void AddState(DocumentStates ds);
        public void AddNumber();
        public void AddDate();
        public void AddContent(string content);
        public void AddCorrespondent(string correspondent);
        public void AddClassificationLevel(СlassificationLevels cl);
        public void AddDocumentState(DocumentStates ds);
        public void AddUnit(Units unit);
        public void AddDeadline(DateTime deadline);
        public void AddExecutor(string executor);
        public void AddRequester(string requester);
        public void AddResources(string resources);
    }
}
