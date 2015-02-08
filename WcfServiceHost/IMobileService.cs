using System.Collections.Generic;
using System.ServiceModel;
using WcfServiceHost.Model;

namespace WcfServiceHost
{
    [ServiceContract]
    public interface IMobileService
    {
        //TODO: Step 1 - Define our service contract
        [OperationContract]
        string GetRandomMobileName();

        [OperationContract]
        IEnumerable<MobileInformation> GetMobileMatch(MobileQuery query);
    }
}
