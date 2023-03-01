using MDD4All.SpecIF.DataModels;

namespace MDD4All.SpecIF.DomainModels.Base
{
    public abstract class SpecIfResource
    {
        public SpecIfResource() 
        {
            
        }

        public abstract Resource Resource { get; }

        public abstract Key Class { get; }

        
    }
}
