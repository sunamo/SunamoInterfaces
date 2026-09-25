namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Manages progress state and progress events.
/// </summary>
public class ProgressState
{
    private int currentCount;

    /// <summary>
    /// Gets or sets a value indicating whether progress events are registered.
    /// </summary>
    public bool IsRegistered { get; set; }

    /// <summary>
    /// Initializes progress tracking with event handlers.
    /// </summary>
    /// <param name="overallItems">Handler for overall item count updates.</param>
    /// <param name="anotherItem">Handler for individual item progress updates.</param>
    /// <param name="writeProgressBarEnd">Handler for progress completion.</param>
    public void Init(Action<int> overallItems, Action<int> anotherItem, Action writeProgressBarEnd)
    {
        IsRegistered = true;
        this.AnotherItem += anotherItem;
        this.OverallItems += overallItems;
        this.WriteProgressBarEnd += writeProgressBarEnd;
    }

    /// <summary>
    /// Event raised when another item is processed.
    /// </summary>
    public event Action<int>? AnotherItem;

    /// <summary>
    /// Event raised when the overall item count is set.
    /// </summary>
    public event Action<int>? OverallItems;

    /// <summary>
    /// Event raised when progress bar ends.
    /// </summary>
    public event Action? WriteProgressBarEnd;

    /// <summary>
    /// Increments and raises the another item event with the current count.
    /// </summary>
    public void OnAnotherItem()
    {
        currentCount++;
        OnAnotherItem(currentCount);
    }

    /// <summary>
    /// Raises the another item event with the specified count.
    /// </summary>
    /// <param name="count">The current item count.</param>
    public void OnAnotherItem(int count)
    {
        AnotherItem?.Invoke(count);
    }

    /// <summary>
    /// Sets the overall item count and raises the overall items event.
    /// </summary>
    /// <param name="totalCount">The total item count.</param>
    public void OnOverallItems(int totalCount)
    {
        currentCount = 0;
        OverallItems?.Invoke(totalCount);
    }

    /// <summary>
    /// Raises the progress bar end event.
    /// </summary>
    public void OnWriteProgressBarEnd()
    {
        WriteProgressBarEnd?.Invoke();
    }
}
