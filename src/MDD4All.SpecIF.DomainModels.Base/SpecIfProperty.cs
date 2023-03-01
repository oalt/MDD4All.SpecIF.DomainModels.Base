using MDD4All.SpecIF.DataModels;
using System;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfProperty
    {
        public Property Property { get; set; } = new Property();

        public bool HasValue
        {
            get
            {
                bool result = false;

                if(Property.Values != null && Property.Values.Count > 0)
                {
                    result = true;
                }

                return result;
            }
        }

    }
}
