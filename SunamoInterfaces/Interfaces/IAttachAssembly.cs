namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for assembly attachment operations.
/// </summary>
public interface IAttachAssembly
{
    /// <summary>
    /// Attaches an assembly and returns its identifier.
    /// </summary>
    /// <returns>Assembly identifier.</returns>
    string Attach();
}