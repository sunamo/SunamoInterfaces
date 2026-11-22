namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the progress state type.
/// </summary>
public class ProgressState
{
    private int currentCount;

    /// <summary>
    /// Gets or sets the is registered.
    /// </summary>
    public bool IsRegistered { get; set; }

    /// <summary>
    /// Init.
    /// </summary>
    /// <param name="overallItems">The overall items.</param>
    /// <param name="anotherItem">The another item.</param>
    /// <param name="writeProgressBarEnd">The write progress bar end.</param>
    /// <returns>The init result.</returns>
    public void Init(Action<int> overallItems, Action<int> anotherItem, Action writeProgressBarEnd)
    {
        IsRegistered = true;
        this.AnotherItem += anotherItem;
        this.OverallItems += overallItems;
        this.WriteProgressBarEnd += writeProgressBarEnd;
    }

    /// <summary>
    /// The another item.
    /// </summary>
    public event Action<int>? AnotherItem;

    /// <summary>
    /// The overall items.
    /// </summary>
    public event Action<int>? OverallItems;

    /// <summary>
    /// The write progress bar end.
    /// </summary>
    public event Action? WriteProgressBarEnd;

    /// <summary>
    /// On another item.
    /// </summary>
    public void OnAnotherItem()
    {
        currentCount++;
        OnAnotherItem(currentCount);
    }

    /// <summary>
    /// On another item.
    /// </summary>
    /// <returns>The on another item result.</returns>
    public void OnAnotherItem(int count)
    {
        AnotherItem?.Invoke(count);
    }

    /// <summary>
    /// On overall items.
    /// </summary>
    public void OnOverallItems(int totalCount)
    {
        currentCount = 0;
        OverallItems?.Invoke(totalCount);
    }

    /// <summary>
    /// On write progress bar end.
    /// </summary>
    /// <param name="count">The count.</param>
    public void OnWriteProgressBarEnd()
    {
        WriteProgressBarEnd?.Invoke();
    }
}
