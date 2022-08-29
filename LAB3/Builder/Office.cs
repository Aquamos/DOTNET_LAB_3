using LAB3.Enums;

namespace LAB3.Builder
{
    public class Office
    {
        private IDocumentBuilder _builder;

        public IDocumentBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildDecree(string content, 
                                DocumentStates documentStates,
                                string correspondent, 
                                СlassificationLevels cLvl,
                                Units unit,
                                DateTime deadline)
        {
            this._builder.AddType(Types.Decree);
            this._builder.AddNumber();
            this._builder.AddDate();
            this._builder.AddContent(content);
            this._builder.AddDocumentState(documentStates);
            this._builder.AddCorrespondent(correspondent);
            this._builder.AddClassificationLevel(cLvl);
            this._builder.AddUnit(unit);
            this._builder.AddDeadline(deadline);
            this._builder.AddDocumentToContext();
        }

        public void BuildLetter(string content,
                                DocumentStates documentStates,
                                string correspondent,
                                СlassificationLevels cLvl)
        {
            this._builder.AddType(Types.Letter);
            this._builder.AddNumber();
            this._builder.AddDate();
            this._builder.AddContent(content);
            this._builder.AddDocumentState(documentStates);
            this._builder.AddCorrespondent(correspondent);
            this._builder.AddClassificationLevel(cLvl);
            this._builder.AddDocumentToContext();
        }
        public void BuildOrder(string content,
                               DocumentStates documentStates,
                               string correspondent,
                               СlassificationLevels cLvl,
                               Units unit,
                               DateTime deadline,
                               string executor)
        {
            this._builder.AddType(Types.Order);
            this._builder.AddNumber();
            this._builder.AddDate();
            this._builder.AddContent(content);
            this._builder.AddDocumentState(documentStates);
            this._builder.AddCorrespondent(correspondent);
            this._builder.AddClassificationLevel(cLvl);

            this._builder.AddUnit(unit);
            this._builder.AddDeadline(deadline);
            this._builder.AddExecutor(executor);
            this._builder.AddDocumentToContext();
        }
        public void BuildRequest(string content,
                                 DocumentStates documentStates,
                                 string correspondent,
                                 СlassificationLevels cLvl,
                                 string requester,
                                 string resources)
        {
            this._builder.AddType(Types.Request);
            this._builder.AddNumber();
            this._builder.AddDate();
            this._builder.AddContent(content);
            this._builder.AddDocumentState(documentStates);
            this._builder.AddCorrespondent(correspondent);
            this._builder.AddClassificationLevel(cLvl);
            this._builder.AddRequester(requester);
            this._builder.AddResources(resources);
            this._builder.AddDocumentToContext();
        }
    }
}
