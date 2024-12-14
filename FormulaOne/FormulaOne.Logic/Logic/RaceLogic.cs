using FormulaOne.Data;
using FormulaOne.Entities.Dtos.Driver;
using FormulaOne.Entities.Dtos.Race;
using FormulaOne.Entities.Entity_Models;
using FormulaOne.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Logic.Logic
{
    public class RaceLogic
    {
        Repository<Race> repo;
        DtoProvider dtoProvider;

        public RaceLogic(Repository<Race> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }
        public void AddRace(RaceCreateDto dto)
        {
            Race r = dtoProvider.Mapper.Map<Race>(dto);
            if (repo.GetAll().FirstOrDefault(x => x.RaceName == r.RaceName) == null)
            {
                repo.Create(r);
            }
            else
            {
                throw new ArgumentException("Ilyen névvel már létezik verseny!");
            }
        }

        public IEnumerable<RaceViewDto> GetAllRaces()
        {
            return repo.GetAll().Select(x =>
                dtoProvider.Mapper.Map<RaceViewDto>(x)
            );
        }

        public void DeleteRace(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateRace(string id, RaceCreateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }

        public RaceViewDto GetRace(string id)
        {
            var race = repo.FindById(id);
            return dtoProvider.Mapper.Map<RaceViewDto>(race);
        }
    }
}
