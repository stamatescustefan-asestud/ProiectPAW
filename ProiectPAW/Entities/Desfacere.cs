using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ComertApp.Custom_Exceptions;

namespace ComertApp.Entities
{
    public class Desfacere
    {
        [Key]
        public int IdDesfacere { get; set; }
        [Required]
        [StringLength(100)]
        public string ProdusVandut { get; set; }
        public int Cantitate { get; set; }
        public decimal Valoare { get; set; }

        private DateOnly _dataVanzarii;
        public DateOnly DataVanzarii
        {
            get { return _dataVanzarii; }
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Today))
                    throw new InvalidSaleDateException(value);
                _dataVanzarii = value;
            }
        }
        [Required]
        public int IdRaion { get; set; }
        [ForeignKey("IdRaion")]
        [JsonIgnore]
        public virtual Raion? Raion { get; set; }
    }
}
