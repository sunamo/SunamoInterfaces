namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for music web service operations.
/// </summary>
/// <typeparam name="ArtistSimplified">The simplified artist type.</typeparam>
/// <typeparam name="AlbumSimplified">The simplified album type.</typeparam>
/// <typeparam name="ArtistFull">The full artist type.</typeparam>
/// <typeparam name="AlbumFull">The full album type.</typeparam>
public interface IMusicWebService<ArtistSimplified, AlbumSimplified, ArtistFull, AlbumFull>
{
    /// <summary>
    /// Gets the album information for a track.
    /// </summary>
    /// <param name="artist">The artist name.</param>
    /// <param name="title">The track title.</param>
    /// <param name="album">The output album name.</param>
    /// <returns>The simplified album information.</returns>
    AlbumSimplified GetAlbumOfTrack(string artist, string title, out string album);
}