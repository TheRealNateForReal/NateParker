namespace NateParker.ViewModels.Quilmes
{
    using NateParker.Data;
    using NateParker.Models.Quilmes;

    public class PlayerViewModel
    {
        public PlayerViewModel(QuilmesDataContext context)
        {
            Players = context.Players.ToList();
        }

        public List<Player> Players { get; set; }
    }
}
