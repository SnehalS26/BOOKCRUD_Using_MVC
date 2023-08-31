using System.ComponentModel.DataAnnotations;

namespace CRUD_Using_MVC.Models
{
    public class Book
    {
        [Key] //to define this is PK col in DB
        [ScaffoldColumn(false)]  //bcz this is identity col , no need to display
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } //allow null from DB
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Author { get; set; }

        [ScaffoldColumn(false)]
        public int isActive { get; set; }
        
    }
}
