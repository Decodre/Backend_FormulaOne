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
    public class Driver : IIdEntity
    {
        public Driver(string firstName, string lastName, string team)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Team = team;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } // Primary Key
        [StringLength(50)]
        public string FirstName { get; set; } = "";
        [StringLength(50)]
        public string LastName { get; set; } = "";
        [StringLength(100)]
        public string Team { get; set; } = "";

        // Navigation property for related RaceResults
        [NotMapped]
        public virtual ICollection<RaceResult> RaceResults { get; set; } = new List<RaceResult>();
    }
}
