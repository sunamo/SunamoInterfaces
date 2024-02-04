namespace SunamoPercentCalculator;

public interface IPercentCalculator
{
    void AddOnePercent();
    int PercentFor(double value, bool last);
    void ResetComputedSum();
}