using System;
using System.ServiceModel;

namespace Xamarin.Tuvi2015.Client
{
    public static class MobileServiceClientHelper
    {
        //TODO: Step 3 - Define the service endpoint
#if DEBUG
        private static readonly EndpointAddress ServiceEndPoint =
            new EndpointAddress("http://192.168.1.104/MobileService/MobileService.svc");
#else
        private static readonly EndpointAddress ServiceEndPoint = new EndpointAddress("http://192.168.1.104/MobileService/MobileService.svc");
#endif

        //TODO: Step 4 - Create our binding
        private static BasicHttpBinding CreateBasicHttpBinding()
        {
            var binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            var timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;

            return binding;
        }

        //TODO: Step 5 - Create a method that provides a configured service client
        public static MobileServiceClient CreateMobileServiceClient()
        {
            return new MobileServiceClient(CreateBasicHttpBinding(), ServiceEndPoint);
        }
    }
}