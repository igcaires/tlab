using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TLabApi.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string UserId { get; set; }
    }
}
