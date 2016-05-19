using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V6_MVC.Models
{
    public class TestViewModel
    {
        private const string t = "test";

        [DisplayName(t)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Alter")]
        [Range(0,150)]
        public int Age { get; set; }
    }
}
