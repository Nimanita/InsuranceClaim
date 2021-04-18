using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.Model
{
    public class PatientDetail
    {
        public long id { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        public String ailment { get; set; }
        public String treatmentPackageName { get; set; }
        public String treatmentCommencementDate { get; set; }
    }
}
