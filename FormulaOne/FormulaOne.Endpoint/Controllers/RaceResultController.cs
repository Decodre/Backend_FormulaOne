using FormulaOne.Entities.Dtos.Race;
using FormulaOne.Entities.Dtos.RaceResult;
using FormulaOne.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOne.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceResultController : ControllerBase
    {
        RaceResultLogic logic;

        public RaceResultController(RaceResultLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void AddRaceResult(RaceResultCreateDto dto)
        {
            logic.AddRaceResult(dto);
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void DeleteRaceResult(string id)
        {
            logic.DeleteRaceResult(id);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public void UpdateRaceResult(string id, [FromBody] RaceResultCreateDto dto)
        {
            logic.UpdateRaceResult(id, dto);
        }
    }
}
