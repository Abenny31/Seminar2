using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Algebra_seminar_2.Models
{
    [Table("Zaposlenik")]
    public class Zaposlenik
    {
        [Key]
        public int IdZaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korisnik { get; set; }
        public string Lozinka { get; set; }
    }
}