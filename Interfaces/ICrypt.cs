namespace
#if SunamoCl
SunamoCl
#elif SunamoCrypt
SunamoCrypt
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface ICrypt
{
    List<byte> s { set; get; }
    List<byte> iv { set; get; }
    string pp { set; get; }
}