using System.ComponentModel.DataAnnotations;

namespace BulkyWebApp.Models
{
    public class Catergory
    {
        [Key]
        public  int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int Display_Order { get; set; }
    }
}
