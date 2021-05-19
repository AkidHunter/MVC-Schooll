using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Vak
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Naam { get; set; }

        [Display(Name = "Docent")]
        [ForeignKey("Docent")]
        public int DocentId { get; set; }

        public virtual Docent Docent { get; set; }

    }
}
