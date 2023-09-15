using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ProductAddModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "The number of characters in the Product Name has been exceeded (Max 20)")]
        public string? ProductName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The number of characters in the Description has been exceeded (Max 40)")]
        public string? Description { get; set; }
        [Required]
        public string? CategoryId { get; set; }
    }
}
