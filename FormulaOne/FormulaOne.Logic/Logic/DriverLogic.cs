using FormulaOne.Data;
using FormulaOne.Entities.Dtos.Driver;
using FormulaOne.Entities.Entity_Models;
using FormulaOne.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Logic.Logic
{
    public class DriverLogic
    {
        Repository<Driver> repo;
        DtoProvider dtoProvider;

        public DriverLogic(Repository<Driver> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddDriver(DriverCreateUpdateDto dto)
        {
            Driver d = dtoProvider.Mapper.Map<Driver>(dto);
            if (repo.GetAll().FirstOrDefault(x => x.FirstName == d.FirstName && x.LastName == d.LastName) == null)
            {
                repo.Create(d);
            }
            else
            {
                throw new ArgumentException("Ilyen névvel már létezik versenyző!");
            }
        }

        public IEnumerable<DriverViewDto> GetAllDrivers()
        {
            return repo.GetAll().Select(x =>
                dtoProvider.Mapper.Map<DriverViewDto>(x)
            );
        }

        public void DeleteDriver(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateDriver(string id, DriverCreateUpdateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }

        public DriverViewDto GetDriver(string id)
        {
            var driver = repo.FindById(id);
            return dtoProvider.Mapper.Map<DriverViewDto>(driver);
        }
    }
}
