using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.game
{
    public class GameRepo : IGame
    {
        public Game getGameByTitle(string title)
        {
            return getGames().FirstOrDefault(p => p.gTitle == title);
        }

        public IEnumerable<Game> getGames() =>
            new List<Game>
            {
                new Game{gTitle="League of Legends", image="~/images/Games/LoL.jpg", dev="Riot Games", releaseDate="October 27, 2009", notes="I have an extreme love / hate releationship with this game, but I've spent over five thousand hours playing it so I can't just stop"},
                new Game{gTitle="Dark Souls(All 3)", image="~/images/Games/DS1.jpg", dev="From Software", releaseDate="September 22, 2011", notes="There are three dark souls games, I put them all together as I like them all pretty equally and have spent a combined nine thousand hours with them" },
                new Game{gTitle="Ratchet: Deadlocked", image="~/images/Games/RDL.jpg", dev="Insomniac", releaseDate="October 25, 2005", notes="I played a lot of games growing up and I know that I can never go back and experience this game like I did for the first time."},
                new Game{gTitle="Minecraft", image="~/images/Games/MC.jpg", dev="Mojang", releaseDate="November 18, 2011", notes="There are just so many possibilities it's insane, I have sunk quite a few hours in with friends and between all the different mods available it feels like a new game everytime." },
                new Game{gTitle="Apex Legends", image="~/images/Games/Apex.jpg", dev="Respawn Entertainment", releaseDate="February 4, 2019", notes="I don't really love it, but it's one of the only games that my friends will consistenly play and I find playing with friends to be fun, therefore this game is fun" }
            };
    }
}
