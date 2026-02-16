namespace NateParker.Models.Quilmes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Card")]
    public class Card
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int PlayerID { get; set; }
        public required virtual Player Player { get; set; }

        public int MatchID { get; set; }
        public required virtual Match Match { get; set; }

        public int TypeID { get; set; }
        public required virtual CardType CardType { get; set; }
    }
 }