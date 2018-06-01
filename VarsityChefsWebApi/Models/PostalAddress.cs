using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    public class PostalAddress
    {
        public int Id { get; set; }
        public string PostalLine1 { get; set; }
        public string PostalLine2 { get; set; }
        public string PostalLine3 { get; set; }
        public string PostalCity { get; set; }
        public string PostalSurburb { get; set; }
        public string PostalProvince { get; set; }
        public string PostalCountry { get; set; }
        public string PostalCode { get; set; }
    }
}
