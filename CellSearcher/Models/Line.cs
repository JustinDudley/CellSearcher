using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CellSearcher.Models {
    public class Line {

        [Required]
        public int Id { get; set; }
        [StringLength(100)]
        public string Comments { get; set; }
        public int AlgId { get; set; }
        public int CellId { get; set; }



    }
}
