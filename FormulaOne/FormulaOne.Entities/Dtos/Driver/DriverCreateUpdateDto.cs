using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Dtos.Driver
{
    public class DriverCreateUpdateDto
    {
        public required string FirstName { get; set; } = "";
        public required string LastName { get; set; } = "";
        public required string Team { get; set; } = "";
    }
}
