using System.Net.NetworkInformation;

namespace MAC_ADDRESS.Services
{
    public class MacAddressService
    {
        public string GetMacAddress()
        {
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    var address = networkInterface.GetPhysicalAddress();
                    if (address != null && address.ToString() != "")
                    {
                        return address.ToString();
                    }
                }
            }
            return "MAC Address not found";
        }
    }
}
