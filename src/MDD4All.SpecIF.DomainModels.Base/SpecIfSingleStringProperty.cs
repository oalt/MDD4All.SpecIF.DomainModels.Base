using MDD4All.SpecIF.DataModels;
using MDD4All.SpecIF.DataModels.Manipulation;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfSingleStringProperty : SpecIfSingleValueProperty
    {
        protected abstract string Format { get; }


        public string DefaultLanguageValue
        {
            get
            {
                return Property.GetSingleStringValue();
            }
            set
            {
                Property.SetSingleStringValue(value, "en", Format);
            }
        }

        public void SetNonDefaultLanguageValue(string value, string langageCode)
        {
            Property.SetSingleStringValue(value, langageCode);
        }

        public override string ToString()
        {
            string result = "";

            result += Property.Class + "\r\n";

            result += DefaultLanguageValue;

            return result;
        }
    }
}

