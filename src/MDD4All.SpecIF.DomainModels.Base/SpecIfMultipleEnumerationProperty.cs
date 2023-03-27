using MDD4All.SpecIF.DataModels;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfMultipleEnumerationProperty<T> : SpecIfProperty
    {
        public abstract List<T> Values { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += "[" + Property.Class + "] ";
            
            int counter = 0;
            foreach (T value in Values)
            {
                result += value.ToString(); 

                if(counter < Values.Count - 1) 
                {
                    result += ", ";
                }
            }

            return result;
        }

    }
}
