using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using Heqa.Model;

namespace Heqa.BL
{
    public class GetSystemIps
    {
        public List<NetInterface> Get()
        {
            var netInterfaces = new List<NetInterface>();
            foreach (NetworkInterface netInterface in  NetworkInterface.GetAllNetworkInterfaces())
            {
                var netInterfaceModel = new NetInterface { Name = netInterface.Name, Description = netInterface.Description};

                IPInterfaceProperties ipProps = netInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    netInterfaceModel.Addresses.Add(addr.Address.ToString());
                }

                netInterfaces.Add(netInterfaceModel);

                System.Diagnostics.Debug.WriteLine("");
            }

            return netInterfaces;
        }
    }
}
