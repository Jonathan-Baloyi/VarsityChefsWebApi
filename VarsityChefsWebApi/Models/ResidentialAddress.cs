using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    public class ResidentialAddress
    {
        public int Id { get; set; }
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
