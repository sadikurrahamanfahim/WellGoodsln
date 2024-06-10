using System.ComponentModel.DataAnnotations;

namespace WellGoodsln.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }

        
        [StringLength(100)]
        public string Address { get; set; }


    }
}
