using System.ComponentModel.DataAnnotations;

namespace HamzaeljayiEXOFINAL.Models
{
    public class FAQItem
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(300)]
            public string Question { get; set; }

            [Required]
            [MaxLength(1500)]
            public string Answer { get; set; }

            [MaxLength(50)]
            public string Category { get; set; }

            public bool IsActive { get; set; } = true;

            public DateTime CreatedDate { get; set; } = DateTime.Now;
        }
    }


