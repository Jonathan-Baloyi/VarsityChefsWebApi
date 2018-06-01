using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    public class AlternativePerson
    {
        public int Id { get; set; }
        public string AlternativeName { get; set; }
        public string AlternativeSurname { get; set; }
        public string AlternativeInitials { get; set; }
        public string AlternativeRelationShip { get; set; }
        public string AlternativeCellNumber { get; set; }
        public string AlternativeTelephone { get; set; }
        public string AlternativeEmailAddress { get; set; }
        public AlternativeAddress AlternativeAddress { get; set; }
    }
}
