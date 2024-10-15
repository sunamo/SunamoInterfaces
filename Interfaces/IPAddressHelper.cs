namespace SunamoInterfaces.Interfaces;
using System.Net.Sockets;

public class IPAddressHelper
{
    /// <summary>
    ///     Vrátí null pokud cokoliv nebude sedět
    /// </summary>
    /// <param name="ip2"></param>
    public static byte[] GetIPAddressInArray(string ip2)
    {
        byte[] ip = null;
        var ips = ip2.Split(new char['.']).ToList();
        if (ips.Count == 4)
        {
            ip = new byte[4];
            for (var i = 0; i < 4; i++)
            {
                byte b = 0;
                if (!byte.TryParse(ips[i], out b)) return null;
                ip[i] = b;
            }
        }

        return ip;
    }


    /// <summary>
    ///     Find with everyline and insert
    /// </summary>
    /// <param name="ip"></param>
    /// <returns></returns>
    public static bool? IsIpAddress(string ip)
    {
        IPAddress address;
        if (IPAddress.TryParse(ip, out address))
            switch (address.AddressFamily)
            {
                case AddressFamily.InterNetwork:
                    // we have IPv4
                    return true;
                    break;
                case AddressFamily.InterNetworkV6:
                    return false;
                    // we have IPv6
                    break;
            }

        return null;
    }
}

// Must import System.Web, not creating this class
//public class HttpRequest
//{

//}