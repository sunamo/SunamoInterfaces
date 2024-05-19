namespace
#if SunamoFtp
SunamoFtp
#else
SunamoInterfaces
#endif
;
public interface IWorking
{
    bool IsWorking { get; }
}