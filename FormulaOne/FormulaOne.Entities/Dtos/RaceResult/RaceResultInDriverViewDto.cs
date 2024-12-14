using FormulaOne.Entities.Dtos.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.RaceResult
{
    public class RaceResultInDriverViewDto
    {
        public string Id { get; set; } = "";
        public int Position { get; set; }
        public virtual RaceViewInResultsDto? Race { get; set; }
    }
}
