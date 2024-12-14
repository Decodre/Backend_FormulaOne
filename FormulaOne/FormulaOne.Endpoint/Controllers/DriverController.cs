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
    public class DriverController : ControllerBase
    {
        DriverLogic logic;

        public DriverController(DriverLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void AddDriver(DriverCreateUpdateDto dto)
        {
            logic.AddDriver(dto);
        }
        [HttpGet]
        public IEnumerable<DriverViewDto> GetAllDrivers()
        {
            return logic.GetAllDrivers();
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void DeleteDriver(string id)
        {
            logic.DeleteDriver(id);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public void UpdateDriver(string id , [FromBody] DriverCreateUpdateDto dto)
        {
            logic.UpdateDriver(id, dto);
        }
        [HttpGet("{id}")]
        public DriverViewDto GetDriver(string id)
        {
            return logic.GetDriver(id);
        }
    }
}
