using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    public class Application
    {
        public int Id { get; set; }

        public int ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellNumber { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string IdNumber { get; set; }
        public string passportNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public bool DoYouHaveApermentResidence { get; set; }
        public string BootSize { get; set; }
        public string JacketSize { get; set; }
        public bool DoYouHaveAnyDisability { get; set; }
        public string Disability { get; set; }
        public bool DoYouHaveAnyAllegies { get; set; }
        public string Allegies { get; set; }
        public bool HaveYouParticipatedInCookingShowBefore { get; set; }
        public string WhichCookingShows { get; set; }

        public ResidentialAddress ResidentialAddress { get; set; }

        public AlternativePerson AlternativePerson { get; set; }

        public PostalAddress PostalAddress { get; set; }

        public bool HaveYouOrYourParentsBeenEmployedByVarsityChefs { get; set; }
        public string Institution { get; set; }
        public string YearOfStudy { get; set; }
        public string Qualification { get; set; }
        public string YearStarted { get; set; }
        public bool Declaration { get; set; }
        public DateTime DateRegistered { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }

    }  
}
