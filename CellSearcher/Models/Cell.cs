using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CellSearcher.Models {
    public class Cell {

        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(12)]
        public string CellString { get; set; }
        [StringLength(30)]
        public string Nickname { get; set; }

        public Cell() {

        }

        public Cell(string cellString, string nickname) {
            CellString = cellString;
            Nickname = nickname;
        }


    }
}
