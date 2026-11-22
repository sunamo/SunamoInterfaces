namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i sunamo dictionary t u type.
/// </summary>
public interface ISunamoDictionary<T, U>
{
    /// <summary>
    /// Gets or sets the this t.
    /// </summary>
    U this[T key] { get; set; }

    /// <summary>
    /// Gets the keys.
    /// </summary>
    ICollection<T> Keys { get; }

    /// <summary>
    /// Gets the values.
    /// </summary>
    ICollection<U> Values { get; }

    /// <summary>
    /// Gets the count.
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Gets the is read only.
    /// </summary>
    bool IsReadOnly { get; }

    /// <summary>
    /// Add.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    void Add(T key, U value);

    /// <summary>
    /// Add.
    /// </summary>
    /// <param name="pair">The pair.</param>
    void Add(KeyValuePair<T, U> pair);

    /// <summary>
    /// Clear.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The clear result.</returns>
    void Clear();

    /// <summary>
    /// Contains.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The contains result.</returns>
    bool Contains(KeyValuePair<T, U> pair);

    /// <summary>
    /// Contains key.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The contains key result.</returns>
    bool ContainsKey(T key);

    /// <summary>
    /// Copy to.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The copy to result.</returns>
    void CopyTo(KeyValuePair<T, U>[] array, int arrayIndex);

    /// <summary>
    /// Get enumerator.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The get enumerator result.</returns>
    IEnumerator<KeyValuePair<T, U>> GetEnumerator();

    /// <summary>
    /// Remove.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    bool Remove(T key);

    /// <summary>
    /// Remove.
    /// </summary>
    /// <param name="pair">The pair.</param>
    bool Remove(KeyValuePair<T, U> pair);

    /// <summary>
    /// Try get value.
    /// </summary>
    bool TryGetValue(T key, out U value);
}
