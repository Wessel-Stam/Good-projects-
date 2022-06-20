using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC_School.Models
{
    public class Docent
    {
        public int Id { get; set; } 

        [StringLength(20)]
        public string Name { get; set; }
        
        [StringLength(40)]
        public string Achternaam { get; set; }

        [ForeignKey("Locatie"), Display(Name = "locatie")]
        public int LocatieId { get; set; }

        //Dit is de navigatir property
        public virtual Locatie Locatie { get; set; }

        public ICollection<Vak> vakken { get; set; }
    }
}
