using FormulaOne.Entities.Dtos.RaceResult;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.Driver
{
    public class DriverViewDto
    {
        public string Id { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Team { get; set; } = "";
        public IEnumerable<RaceResultInDriverViewDto>? RaceResults { get; set; }
    }
}
