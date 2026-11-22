namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i simple converter t type in class name u type.
/// </summary>
public interface ISimpleConverterT<TypeInClassName, U>
{
    /// <summary>
    /// Convert to.
    /// </summary>
    /// <param name="sourceValue">The source value.</param>
    /// <returns>The convert to result.</returns>
    TypeInClassName ConvertTo(U sourceValue);

    /// <summary>
    /// Convert from.
    /// </summary>
    /// <param name="targetValue">The target value.</param>
    /// <returns>The convert from result.</returns>
    U ConvertFrom(TypeInClassName targetValue);
}
