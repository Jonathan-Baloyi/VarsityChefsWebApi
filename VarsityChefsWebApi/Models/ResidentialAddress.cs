using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    [ComplexType]
    public class ResidentialAddress
    {
        public string ResLine1 { get; set; }
        public string ResLine2 { get; set; }
        public string ResLine3 { get; set; }
        public string ResCity { get; set; }
        public string ResSurburb { get; set; }
        public string ResProvince { get; set; }
        public string ResCountry { get; set; }
        public string ResCode { get; set; }
    }
}
