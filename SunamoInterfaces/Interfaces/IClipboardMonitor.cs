namespace SunamoInterfaces.Interfaces;

public interface IClipboardMonitor
{
    bool? AfterSet { get; set; }

    bool PermanentlyBlock { get; set; }
}
