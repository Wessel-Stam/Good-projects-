using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Vak
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [ForeignKey("DocentId"), Display(Name = "DocentId")]
        public int DocentId { get; set; }

        public virtual Docent Docent { get; set; }
    }
}
