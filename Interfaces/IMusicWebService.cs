
namespace SunamoInterfaces.Interfaces;
public interface IMusicWebService<ArtistSimplified, AlbumSimplified, ArtistFull, AlbumFull>
{
    AlbumSimplified GetAlbumOfTrack(string artist, string title, out string album);
    
}