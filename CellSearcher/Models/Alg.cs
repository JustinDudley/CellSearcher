using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Every user alg and every user cell gets added to the corresponding table
// Later, I'll add a Line row every time the cell goes with the alg.
// for now, that Line table,for many to many, will be created but remain empty.
// For now, no restrictions on the strings I accept.  Could have K, 6, #, whatever, not just RUR'D.
namespace CellSearcher.Models {
    public class Alg {

        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(143)]
        public string AlgString { get; set; }
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(255)]
        public string Description { get; set; }


        public Alg() {

        }

        public Alg(string algString, string label, string description) {
            AlgString = algString;
            Label = label;
            Description = description;
        }
    }
}
