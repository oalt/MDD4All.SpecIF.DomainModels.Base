namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfEnumerationValue
    {
        public string Identifier { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            string result = "";

            if (Identifier != null)
            {
                result += "[" + Identifier + "]";
            }

            if (Title != null)
            {
                result += " " + Title;
            }

            if(Identifier == null && Title == null) 
            {
                result = base.ToString();
            }

            return result;
        }
    }
}
