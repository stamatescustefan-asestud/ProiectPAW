using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ComertApp.Entities
{
    public class Raion
    {
        [Key]
        public int IdRaion { get; set; }
        [Required]
        [StringLength(50)]
        public string Nume { get; set; }
        public int NumarAngajati { get; set; }
        [Required]
        public int IdMagazin { get; set; }
        [ForeignKey("IdMagazin")]
        [JsonIgnore]
        public virtual Magazin? Magazin { get; set; }
        public virtual List<Desfacere> Desfaceri { get; set; } = new();
    }
}
