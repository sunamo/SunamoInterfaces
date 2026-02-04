namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Generic interface for bidirectional type conversion.
/// </summary>
/// <typeparam name="TypeInClassName">The target type used in the class name.</typeparam>
/// <typeparam name="U">The source type to convert from/to.</typeparam>
public interface ISimpleConverterT<TypeInClassName, U>
{
    /// <summary>
    /// Converts from source type to target type.
    /// </summary>
    /// <param name="sourceValue">The source value to convert.</param>
    /// <returns>The converted target value.</returns>
    TypeInClassName ConvertTo(U sourceValue);

    /// <summary>
    /// Converts from target type to source type.
    /// </summary>
    /// <param name="targetValue">The target value to convert.</param>
    /// <returns>The converted source value.</returns>
    U ConvertFrom(TypeInClassName targetValue);
}