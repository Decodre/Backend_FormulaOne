using FormulaOne.Entities.Dtos.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.RaceResult
{
    public class RaceResultInRaceViewDto
    {
        public string Id { get; set; } = "";
        public DriverInRaceViewDto? Driver { get; set; }
        public int Position { get; set; }
    }
}
