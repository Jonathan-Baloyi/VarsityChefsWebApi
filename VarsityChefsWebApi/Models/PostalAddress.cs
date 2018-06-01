using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Models
{
    [ComplexType]
    public class PostalAddress
    {
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
