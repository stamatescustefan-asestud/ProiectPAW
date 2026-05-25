using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComertApp.Entities
{
    public class Magazin
    {
        [Key]
        public int IdMagazin { get; set; }
        [Required]
        [StringLength(100)]
        public string Nume { get; set; }
        [Required]
        [StringLength(100)]
        public string Adresa { get; set; }
        public List<Raion> ListaRaioane { get; set; } = new();
    }
}
