namespace SunamoInterfaces.Interfaces;

public interface IValidateControl
{
    bool Validated { get; set; }
    bool Validate(object tb, object control, ref ValidateData d);
    bool Validate(object tbFolder, ref ValidateData d);

    /// <returns></returns>
    object GetContent();
}