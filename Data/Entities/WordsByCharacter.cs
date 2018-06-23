using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class WordsByCharacter
    {
        [Key]
        public int Id { get; set; }
        public string Film { get; set; }
        public string Chapter { get; set; }
        public string Race { get; set; }
        public string NameCharacter { get; set; }
    }
}
