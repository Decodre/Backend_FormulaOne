using FormulaOne.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.Entity_Models
{
    public class RaceResult : IIdEntity
    {
        public RaceResult(string driverId, string raceId, int position)
        {
            Id = Guid.NewGuid().ToString();
            DriverId = driverId;
            RaceId = raceId;
            Position = position;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } // Primary Key

        // Foreign Key to Driver
        [StringLength(50)]
        public string DriverId { get; set; }
        public virtual Driver? Driver { get; set; }

        // Foreign Key to Race
        [StringLength(50)]
        public string RaceId { get; set; }
        public virtual Race? Race { get; set; }
        [Range(1,22)]
        public int Position { get; set; }
    }
}
