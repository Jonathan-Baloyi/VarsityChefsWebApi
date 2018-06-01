using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    public class AlternativeAddress
    {
        public int Id { get; set; }
        public string AlternativeLine1 { get; set; }
        public string AlternativeLine2 { get; set; }
        public string AlternativeLine3 { get; set; }
        public string AlternativeCity { get; set; }
        public string AlternativeSurburb { get; set; }
        public string AlternativeProvince { get; set; }
        public string AlternativeCountry { get; set; }
        public string AlternativeCode { get; set; }
    }
}
