namespace NateParker.Models.Quilmes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Opponent")]
    public class Opponent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public required string Name { get; set; }
    }
 }