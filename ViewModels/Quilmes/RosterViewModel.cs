namespace NateParker.ViewModels.Quilmes
{
    using NateParker.Data;
    using NateParker.Models.Quilmes;

    public class RosterViewModel
    {
        public RosterViewModel(QuilmesDataContext context)
        {
            var playerDetails = new List<PlayerDetail>();
            var players = context.Players
                .Where(x => x.StatusID == 1)
                .ToList();

            foreach (var player in players)
            {
                playerDetails.Add(new PlayerDetail
                {
                    Player = player,
                    GamesPlayed = context.Appearances.Where(x => x.Player == player).Count(),
                    Goals = context.Goals.Where(x => x.Player == player).Count(),
                    Assists = context.Assists.Where(x => x.Player == player).Count(),
                    Cards = context.Cards.Where(x => x.Player == player).Count().ToString(),
                }); 
            }

            PlayerDetails = playerDetails;
        }

        public List<PlayerDetail> PlayerDetails { get; set; }

        public class PlayerDetail
        {
            public required Player Player { get; set; }
            public int GamesPlayed { get; set; } = 0;
            public int Goals { get; set; } = 0;
            public int Assists { get; set; } = 0;
            public string? Cards { get; set; }
        }
    }
}
