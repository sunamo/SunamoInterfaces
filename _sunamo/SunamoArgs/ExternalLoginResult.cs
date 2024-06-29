namespace SunamoInterfaces;


/// <summary>
/// Jakékoliv změny v této složce musíš projevit i v stejně pojmenované třídě v sunamo projektu
/// </summary>
//[Preserve]
public class ExternalLoginResult //: ExternalLoginResult
{
    internal int IdUser
    {
        get;
        set;
    }
    internal string Sc
    {
        get;
        set;
    }
    /// <summary>
    /// int.MaxValue for never asking
    /// </summary>
    internal string P1
    {
        get;
        set;
    }
}