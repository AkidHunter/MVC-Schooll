using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_School.Models
{
    public class Docent
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Voornaam { get; set; }

        [StringLength(40)]
        public string Achternaam { get; set; }

        [NotMapped]
        public string Naam => $"{Voornaam} {Achternaam}";

        [ForeignKey("Locatie")]
        [Display(Name="Locatie")]

        public int LocatieId { get; set; }

        public virtual Locatie Locatie { get; set; }

        public ICollection<Vak> Vakken { get; set; }

    }
}
