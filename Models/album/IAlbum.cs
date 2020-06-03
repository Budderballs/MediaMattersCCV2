using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.album
{
    public interface IAlbum
    {
        IEnumerable<Album> getAlbums();
        Album getAlbumByTitle(string title);
    }
}
