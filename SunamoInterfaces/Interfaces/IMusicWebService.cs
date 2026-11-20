namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i music web service artist simplified album simplified artist full album full type.
/// </summary>
public interface IMusicWebService<ArtistSimplified, AlbumSimplified, ArtistFull, AlbumFull>
{
    /// <summary>
    /// Get album of track.
    /// </summary>
    /// <param name="artist">The artist.</param>
    /// <param name="title">The title.</param>
    /// <param name="album">The album.</param>
    /// <returns>The get album of track result.</returns>
    AlbumSimplified GetAlbumOfTrack(string artist, string title, out string album);
}
