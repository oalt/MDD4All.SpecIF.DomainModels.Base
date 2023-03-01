using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfSingleEnumerationProperty : SpecIfSingleValueProperty
    {
        public string Value { get; set; }
    }
}
