using AutoMapper;
using FormulaOne.Data;
using FormulaOne.Entities.Dtos.Driver;
using FormulaOne.Entities.Dtos.Race;
using FormulaOne.Entities.Dtos.RaceResult;
using FormulaOne.Entities.Dtos.User;
using FormulaOne.Entities.Entity_Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Logic.Helpers
{
    public class DtoProvider
    {
        UserManager<AppUser> userManager;
        public Mapper Mapper { get; }

        public DtoProvider(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<AppUser, UserViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.IsAdmin = userManager.IsInRoleAsync(src, "Admin").Result;
                });

                cfg.CreateMap<DriverCreateUpdateDto, Driver>();
                cfg.CreateMap<RaceCreateDto, Race>();
                cfg.CreateMap<RaceResultCreateDto, RaceResult>();

                cfg.CreateMap<RaceResult, RaceResultInDriverViewDto>();
                cfg.CreateMap<RaceResult, RaceResultInRaceViewDto>();
                cfg.CreateMap<Race, RaceViewDto>();
                cfg.CreateMap<Race, RaceViewInResultsDto>();
                cfg.CreateMap<Driver, DriverViewDto>();
                cfg.CreateMap<Driver, DriverInRaceViewDto>();
            });

            Mapper = new Mapper(config);
        }
    }
}
