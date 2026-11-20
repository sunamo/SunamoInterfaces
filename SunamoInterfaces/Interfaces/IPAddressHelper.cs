namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IP address helper type.
/// </summary>
public class IPAddressHelper
{
    // Gets IP address as byte array.
    // Returns null if anything doesn't match.
    /// <summary>
    /// Get IP address in array.
    /// </summary>
    /// <param name="ipAddress">The ip address.</param>
    /// <returns>The get IP address in array result.</returns>
    public static byte[]? GetIPAddressInArray(string ipAddress)
    {
        byte[]? addressBytes = null;
        var parts = ipAddress.Split('.').ToList();
        if (parts.Count == 4)
        {
            addressBytes = new byte[4];
            for (var i = 0; i < 4; i++)
            {
                if (!byte.TryParse(parts[i], out byte byteValue))
                {
                    return null;
                }
                addressBytes[i] = byteValue;
            }
        }
        return addressBytes;
    }

    // True if IPv4, false if IPv6, null if not an IP address.
    /// <summary>
    /// Is ip address.
    /// </summary>
    /// <param name="ipAddress">The ip address.</param>
    /// <returns>The is ip address result.</returns>
    public static bool? IsIpAddress(string ipAddress)
    {
        if (IPAddress.TryParse(ipAddress, out IPAddress? address))
        {
            switch (address.AddressFamily)
            {
                case AddressFamily.InterNetwork:
                    return true;
                case AddressFamily.InterNetworkV6:
                    return false;
            }
        }
        return null;
    }
}
