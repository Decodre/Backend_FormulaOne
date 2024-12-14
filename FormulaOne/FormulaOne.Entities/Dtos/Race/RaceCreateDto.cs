using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.Race
{
    public class RaceCreateDto
    {
        public string RaceName { get; set; } = "";
        public string Location { get; set; } = "";
    }
}
