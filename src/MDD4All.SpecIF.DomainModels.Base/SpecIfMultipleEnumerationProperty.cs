using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public class SpecIfMultipleEnumerationProperty : SpecIfProperty
    {
        public List<string> Values { get; set; }

    }
}
