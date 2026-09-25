namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for generating TypeScript code.
/// </summary>
public interface ITypeScriptGenerator
{
    /// <summary>
    /// Generates TypeScript code from the current object.
    /// </summary>
    /// <returns>The generated TypeScript code.</returns>
    string GenerateTypeScript();
}