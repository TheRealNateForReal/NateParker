namespace NateParker.Models.Quilmes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Match")]
    public class Match
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int MatchDay { get; set; }

        [Required]
        public DateTime MatchDate { get; set; }

        public int OpponentID { get; set; }
        public required virtual Opponent Opponent { get; set; }

        public int GoalsFor { get; set; }

        public int GoalsAgainst { get; set; }

        [Required]
        [StringLength(1)]
        public required string Result { get; set; }

        public int SeasonID { get; set; }
        public required virtual Season Season { get; set; }
    }
 }