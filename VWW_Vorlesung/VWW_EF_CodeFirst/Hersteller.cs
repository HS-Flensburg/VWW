using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_EF_CodeFirst
{
    public class Hersteller
    {
        public Hersteller()
        {
            Monitors = new List<Monitor>();
        }
        [Key]
        public int Id { get; set; }
        [DisplayName("Herstellername")]
        [Required]
        public string Name { get; set; }

        public virtual List<Monitor> Monitors { get; set; }

    }
}
