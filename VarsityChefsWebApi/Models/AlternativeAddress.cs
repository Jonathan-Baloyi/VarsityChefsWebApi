using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    [ComplexType]
    public class AlternativeAddress
    {
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
