using System.ComponentModel.DataAnnotations;

namespace Gri.Database
{
    public class Song
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Length { get; set; }

        //[Required] Genre can be unknown
        public string Genre { get; set; }
    }
}
