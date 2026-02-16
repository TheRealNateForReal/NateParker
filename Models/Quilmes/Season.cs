namespace NateParker.Models.Quilmes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Season")]
    public class Season
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required, StringLength(50)]
        public required string DisplayName { get; set; }

        [Required]
        public required int DivisionID { get; set; }
        public required virtual Division Division { get; set; }

        [Required]
        public bool IsCurrent { get; set; }
    }
 }