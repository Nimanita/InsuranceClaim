using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.Model
{
    public class TreatmentPlan
    {
        public long id { get; set; }
        public PatientDetail ptDetail { get; set; }
        public String testDetails { get; set; }
        public String packageName { get; set; }
        public String specialist { get; set; }
        public double cost { get; set; }
        public String status { get; set; }
        public String treatmentCommenceDate { get; set; }
        public String treatmentEndDate { get; set; }
    }
}
