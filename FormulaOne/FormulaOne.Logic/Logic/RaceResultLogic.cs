using FormulaOne.Data;
using FormulaOne.Entities.Dtos.Driver;
using FormulaOne.Entities.Dtos.Race;
using FormulaOne.Entities.Dtos.RaceResult;
using FormulaOne.Entities.Entity_Models;
using FormulaOne.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Logic.Logic
{
    public class RaceResultLogic
    {
        Repository<RaceResult> repo;
        DtoProvider dtoProvider;

        public RaceResultLogic(Repository<RaceResult> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddRaceResult(RaceResultCreateDto dto)
        {
            RaceResult r = dtoProvider.Mapper.Map<RaceResult>(dto);
            if (repo.GetAll().FirstOrDefault(x => x.DriverId == r.DriverId && x.RaceId == r.RaceId) == null)
            {
                repo.Create(r);
            }
            else
            {
                throw new ArgumentException("Már létezik ehhez a versenyzőhöz helyezés a versenyen!");
            }
        }
        public void DeleteRaceResult(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateRaceResult(string id, RaceResultCreateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }
    }
}
