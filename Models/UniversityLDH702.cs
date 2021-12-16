using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace LeDuyHieu702.Models
{
    [Table("University")]
    public class UniversityLDH702
    {
        [Key]
        [StringLength(20)]
        [DisplayName("Mã Trường")]
        [Required]
        public string UniversityId { get; set; }

        [DisplayName("Tên Trường")]
        [StringLength(50)]
        [Required]
        public string UniversityName { get; set; }
    }
}