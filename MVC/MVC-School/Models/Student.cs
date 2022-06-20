using System.ComponentModel.DataAnnotations;

namespace MVC_School.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(20)]

        public string Voornaam { get; set; } = string.Empty;

        [StringLength(40)]

        public string Achternaam { get; set; } = string.Empty;

        [StringLength(40)]

        public string Adres { get; set; } = string.Empty;

        [StringLength(40)]

        public string Woonplaats { get; set; } = string.Empty;

    }
}
