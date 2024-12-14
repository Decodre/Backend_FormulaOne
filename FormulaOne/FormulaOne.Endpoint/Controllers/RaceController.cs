using FormulaOne.Entities.Dtos.Driver;
using FormulaOne.Entities.Dtos.Race;
using FormulaOne.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOne.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        RaceLogic logic;

        public RaceController(RaceLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void AddRace(RaceCreateDto dto)
        {
            logic.AddRace(dto);
        }
        [HttpGet]
        public IEnumerable<RaceViewDto> GetAllRace()
        {
            return logic.GetAllRaces();
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void DeleteRace(string id)
        {
            logic.DeleteRace(id);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public void UpdateRace(string id, [FromBody] RaceCreateDto dto)
        {
            logic.UpdateRace(id, dto);
        }
        [HttpGet("{id}")]
        public RaceViewDto GetRace(string id)
        {
            return logic.GetRace(id);
        }
    }
}
