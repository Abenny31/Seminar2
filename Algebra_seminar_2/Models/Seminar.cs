using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Algebra_seminar_2.Models
{
    [Table("Seminar")]
    public class Seminar
    {
        [Key]
        public int IdSeminar { get; set; }
        
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }

    }
}