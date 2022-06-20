using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVC_School.Models;

namespace MVC_School.Models
{
    public class Locatie
    {
        public Locatie()
        {
            Docenten = new HashSet<Docent>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        public string Naam { get; set; }

        [StringLength(40)]
        public string Adres { get; set; }

        [StringLength(40)]
        public string Woonplaats { get; set; }

        public ICollection<Docent> Docenten { get; set; }
    }

}