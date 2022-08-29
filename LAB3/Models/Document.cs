using LAB3.Enums;


namespace LAB3.Models
{
    public class Document
    {
        public int Id { get; set; }
        public Types Type { get; set; }
        public DocumentStates documentState { get; set; }
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            str += $"Type: {Type}\n";
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "\n";
            }
            return str;
        }
    }
}
