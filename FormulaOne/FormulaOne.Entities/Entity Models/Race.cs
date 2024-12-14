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
    public class Race : IIdEntity
    {
        public Race(string raceName, string location)
        {
            Id = Guid.NewGuid().ToString();
            RaceName = raceName;
            Location = location;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } // Primary Key
        [StringLength(100)]
        public string RaceName { get; set; } = "";
        [StringLength(50)]
        public string Location { get; set; } = "";

        // Navigation property for related RaceResults
        [NotMapped]
        public virtual ICollection<RaceResult> RaceResults { get; set; } = new List<RaceResult>();
    }
}
