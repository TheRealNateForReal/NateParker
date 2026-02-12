namespace NateParker.Models.Quilmes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Player")]
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        public int? Number { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int StatusID { get; set; }
    }
 }