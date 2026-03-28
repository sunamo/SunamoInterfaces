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

    /// <summary>
    /// Determines whether the specified string is an IP address.
    /// </summary>
    /// <param name="ipAddress">The string to check.</param>
    /// <returns>True if IPv4, false if IPv6, null if not an IP address.</returns>
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
