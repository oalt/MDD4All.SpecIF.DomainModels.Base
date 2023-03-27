namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfSingleEnumerationProperty<T> : SpecIfSingleValueProperty
    {
        public abstract T Value { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += "[" + Property.Class + "] ";
            result += Value.ToString();

            return result;
        }
    }
}
