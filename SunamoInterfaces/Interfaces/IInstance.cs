namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for creating instances of type T from object values.
/// </summary>
/// <typeparam name="T">The type of instance to create.</typeparam>
public interface IInstance<T>
{
    /// <summary>
    /// Creates an instance of type T from the specified value.
    /// </summary>
    /// <param name="value">The value to create the instance from.</param>
    /// <returns>The created instance.</returns>
    T CreateInstance(object value);
}