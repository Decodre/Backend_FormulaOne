using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.RaceResult
{
    public class RaceResultCreateDto
    {
        public required string DriverId { get; set; }
        public required string RaceId { get; set; }
        [Range(1, 22)]
        public required int Position { get; set; }

    }
}
