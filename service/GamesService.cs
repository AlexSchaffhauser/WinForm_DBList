using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexSBProject.service
{
    class GamesService
    {
        GamesDBEntities GDBEntities = new GamesDBEntities();

        public List<GAME> RetrieveGames(string console, bool complete) 
        {
            using (var gameContext = new GamesDBEntities())
            {
                var query = from game in GDBEntities.GAMES
                            select game;
                if (complete)
                {
                    switch(console)
                    {
                        case "NES":
                             query = from game in GDBEntities.GAMES
                                        where game.Console == "NES" && game.Complete == true
                                        select game;
                            return query.ToList<GAME>();
                        case "SNES":
                             query = from game in GDBEntities.GAMES
                                        where game.Console == "SNES" && game.Complete == true
                                        select game;
                            return query.ToList<GAME>();
                        case "N64":
                             query = from game in GDBEntities.GAMES
                                        where game.Console == "N64" && game.Complete == true
                                        select game;
                            return query.ToList<GAME>();
                        case "GCN":
                             query = from game in GDBEntities.GAMES
                                        where game.Console == "GCN" && game.Complete == true
                                        select game;
                            return query.ToList<GAME>();
                        case "Wii":
                             query = from game in GDBEntities.GAMES
                                        where game.Console == "Wii" && game.Complete == true
                                        select game;
                            return query.ToList<GAME>();
                        default:
                            return query.ToList<GAME>();
                    }
                }
                else
                {
                    switch (console)
                    {
                        case "NES":
                            query = from game in GDBEntities.GAMES
                                    where game.Console == "NES"
                                    select game;
                            return query.ToList<GAME>();
                        case "SNES":
                            query = from game in GDBEntities.GAMES
                                    where game.Console == "SNES"
                                    select game;
                            return query.ToList<GAME>();
                        case "N64":
                            query = from game in GDBEntities.GAMES
                                    where game.Console == "N64"
                                    select game;
                            return query.ToList<GAME>();
                        case "GCN":
                            query = from game in GDBEntities.GAMES
                                    where game.Console == "GCN"
                                    select game;
                            return query.ToList<GAME>();
                        case "Wii":
                            query = from game in GDBEntities.GAMES
                                    where game.Console == "Wii"
                                    select game;
                            return query.ToList<GAME>();
                        default:
                            return query.ToList<GAME>();
                    }
                }
            }
        }

        public void AddGame(GAME game) 
        {
            using (var gameContext = new GamesDBEntities())
            {
                gameContext.GAMES.Add(game);
                gameContext.SaveChanges();
            }
        }
        public void EditGame(int gameId)
        {
            using (var gameContext = new GamesDBEntities())
            {

                var query = from game in GDBEntities.GAMES
                            where game.Id == gameId
                            select game;

                foreach (GAME game in query)
                {
                    game.Complete = true;
                    game.DateOfCompletion = DateTime.Today;

                }


                gameContext.SaveChanges();

            }
        }
    }
}
