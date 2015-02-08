using System;
using System.Collections.Generic;
using System.Linq;
using WcfServiceHost.Model;

namespace WcfServiceHost
{
    public class MobileService : IMobileService
    {
        //TODO: Step 2 - Create an implementation our service implementation
        public string GetRandomMobileName()
        {
            var random = new Random();
            var MobileInformation = MobileData.GetMobileInformation();

            return
                MobileInformation.Any()
                    ? MobileInformation.ElementAt(random.Next(MobileInformation.Count)).CommonName
                    : string.Empty;
        }

        public IEnumerable<MobileInformation> GetMobileMatch(MobileQuery query)
        {
            var MobileInformation = MobileData.GetMobileInformation();

            return
                query == null || (String.IsNullOrEmpty(query.Family) && String.IsNullOrEmpty(query.Subfamily) && String.IsNullOrEmpty(query.Genus))
                ? Enumerable.Empty<MobileInformation>()
                : MobileInformation
                    .Where(mi => String.IsNullOrEmpty(query.Family) || mi.Family.IndexOf(query.Family, StringComparison.OrdinalIgnoreCase) >= 0)
                    .Where(mi => String.IsNullOrEmpty(query.Subfamily) || mi.Subfamily.IndexOf(query.Subfamily, StringComparison.OrdinalIgnoreCase) >= 0)
                    .Where(mi => String.IsNullOrEmpty(query.Genus) || mi.Genus.IndexOf(query.Genus, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
