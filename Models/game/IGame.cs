using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.game
{
    public interface IGame
    {
        IEnumerable<Game> getGames();
        Game getGameByTitle(string title);
    }
}
