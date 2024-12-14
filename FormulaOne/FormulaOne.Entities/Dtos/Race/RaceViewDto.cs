using FormulaOne.Entities.Dtos.RaceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.Race
{
    public class RaceViewDto
    {
        public string Id { get; set; } = "";
        public string RaceName { get; set; } = "";
        public string Location { get; set; } = "";
        public IEnumerable<RaceResultInRaceViewDto>? RaceResults { get; set; }
    }
}
