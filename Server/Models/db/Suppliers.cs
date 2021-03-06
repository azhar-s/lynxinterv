using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lynxoma.Server.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string State { get; set; }
    }
}
