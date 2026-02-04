namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Helper class for IP address operations.
/// </summary>
public class IPAddressHelper
{
    /// <summary>
    /// Gets IP address as byte array.
    /// Returns null if anything doesn't match.
    /// </summary>
    /// <param name="ipAddress">IP address string to parse.</param>
    /// <returns>Byte array representing the IP address, or null if parsing fails.</returns>
    public static byte[]? GetIPAddressInArray(string ipAddress)
    {
        byte[]? ip = null;
        var parts = ipAddress.Split('.').ToList();
        if (parts.Count == 4)
        {
            ip = new byte[4];
            for (var i = 0; i < 4; i++)
            {
                byte byteValue = 0;
                if (!byte.TryParse(parts[i], out byteValue))
                {
                    return null;
                }
                ip[i] = byteValue;
            }
        }
        return ip;
    }

    /// <summary>
    /// Determines whether the specified string is an IP address.
    /// </summary>
    /// <param name="ipAddress">The string to check.</param>
    /// <returns>True if IPv4, false if IPv6, null if not an IP address.</returns>
    public static bool? IsIpAddress(string ipAddress)
    {
        IPAddress? address;
        if (IPAddress.TryParse(ipAddress, out address))
        {
            switch (address.AddressFamily)
            {
                case AddressFamily.InterNetwork:
                    // IPv4
                    return true;
                case AddressFamily.InterNetworkV6:
                    // IPv6
                    return false;
            }
        }
        return null;
    }
}