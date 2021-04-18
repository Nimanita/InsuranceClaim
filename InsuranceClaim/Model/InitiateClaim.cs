using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.Model
{
    public class InitiateClaim
    {
        public long id { get; set; }
        public String patientName { get; set; }
        public String ailment { get; set; }
        public Double cost { get; set; }
        public String treatmentPackageName { get; set; }
        public String insurerName { get; set; }
    }
}
