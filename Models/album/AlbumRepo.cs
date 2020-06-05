using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace MediaMattersCCV2.Models.album
{
    public class AlbumRepo : IAlbum
    {
        public Album getAlbumByTitle(string title)
        {
            return getAlbums().FirstOrDefault(p => p.aTitle == title);
        }
        
        public IEnumerable<Album> getAlbums() =>
            new List<Album>
            {
                new Album{aTitle = "Mostly We Grow Pt. 1", image="~/images/Albums/MWGPt1.jpg", artist="Half an Orange", notes="I like it simply it's fun and catchy"},
                new Album{aTitle = "Thrill of it", artist="Conro", image="~/images/Albums/ThrillOfIt.jpg", notes="I don't love the album, but I like the artist and this album is decent" },
                new Album{aTitle="Monstercat Instinct Vol. 4", artist="Monstercat(Various)", image="~/images/Albums/MCIV4.jpg", notes="Less an album and more a compilation of music, but most of it's not bad" },
                new Album{aTitle="PLAY (The Remixes)", artist="Multiple", image="~/images/Albums/Play(Remixes).jpg", notes="More of an EP than an album, it's just all of the remixes of a single song by Tokyo Machine" },
                new Album{aTitle="Nerds by Nature", artist="Pegboard Nerds", image="~/images/Albums/NBN.jpeg", notes="Used to be one of my more liked artist, not so much anymore, but some of their older stuff is pretty good" }
            };
    }
}
