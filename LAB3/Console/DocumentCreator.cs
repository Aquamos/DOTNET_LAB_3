using LAB3.Builder;
using LAB3.Enums;

namespace LAB3.Console
{
    public class DocumentCreator
    {
        private Office office;
        private IDocumentBuilder documentBuilder;
        public DocumentCreator()
        {
            office = new Office();
            documentBuilder = new DocumentBuilder();
            office.Builder = documentBuilder;
        }
        private string content;
        private int state;
        private string correspondent;
        private int clLvl;
        public void CreateDecree()
        {
            (content, state, correspondent, clLvl) = RequestDataForDocument();
            int unit;
            do
            {
                unit = Helper.GetIntFromConsole(
                    "Please enter \'1\' for office or \'2\' for management" +
                    "or \'3\' for production", 1);
            } while (unit != 1 && unit != 2 && unit != 3);

            DateTime deadline = Helper.GetDateFromConsole(
                "Please enter deadline: ");

            office.BuildDecree(content,
                               (DocumentStates)state,
                               correspondent,
                               (СlassificationLevels)clLvl,
                               (Units)unit,
                               deadline);
        }
        public void CreateRequest()
        {
            (content, state, correspondent, clLvl) = RequestDataForDocument();

            string requester = Helper.GetStringFromConsole(
                    "Enter your full name of requester: ");

            string resources = Helper.GetStringFromConsole(
                    "Enter requested resources: ");

            office.BuildRequest(content,
                               (DocumentStates)state,
                               correspondent,
                               (СlassificationLevels)clLvl,
                               requester,
                               resources);
        }
        public void CreateOrder()
        {
            int unit;
            do
            {
                unit = Helper.GetIntFromConsole(
                    "Please enter \'1\' for office or \'2\' for management" +
                    "or \'3\' for production", 1);
            } while (unit != 1 && unit != 2 && unit != 3);

            DateTime deadline = Helper.GetDateFromConsole(
                "Please enter deadline: ");

            string executor = Helper.GetStringFromConsole(
                    "Enter your full name of executor: ");
            (content, state, correspondent, clLvl) = RequestDataForDocument();
            office.BuildOrder(content,
                             (DocumentStates)state,
                             correspondent,
                             (СlassificationLevels)clLvl,
                             (Units)unit,
                             deadline,
                             executor);
        }
        public void CreateLetter()
        {
            (content, state, correspondent, clLvl) = RequestDataForDocument();
            office.BuildLetter(content,
                               (DocumentStates)state,
                               correspondent,
                               (СlassificationLevels)clLvl);
        }
        private (string content, int state, string correspondent, int clLvl) RequestDataForDocument()
        {
            string content = Helper.GetStringFromConsole(
                "Please enter content: ");

            int state;
            do
            {
                state = Helper.GetIntFromConsole(
                    "Please enter \'1\' for incoming doc or \'2\' for outgoing", 1);
            } while (state != 1 && state != 2);

            string corresponent = String.Empty;
            if (state == 1)
                corresponent = Helper.GetStringFromConsole(
                    "Enter your full name: ");
            else if (state == 2)
                corresponent = Helper.GetStringFromConsole(
                    "Enter a sender: ");

            int clLvl;
            do
            {
                clLvl = Helper.GetIntFromConsole(
                    "Please enter \'1\' for trade secret or \'2\' for state secret" +
                    "or \'3\' for public", 1);
            } while (clLvl != 1 && clLvl != 2 && clLvl != 3);

            return (content, state, corresponent, clLvl);
        }
    }
}
