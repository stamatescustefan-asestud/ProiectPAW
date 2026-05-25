using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComertApp.Models
{
    internal class DesfacereViewModel
    {
        public int IdDesfacere { get; set; }
        public string ProdusVandut { get; set; }
        public int Cantitate { get; set; }
        public decimal Valoare { get; set; }
        public DateOnly DataVanzarii { get; set; }
        public string NumeRaion { get; set; }
        public string NumeMagazin { get; set; }
    }
}
