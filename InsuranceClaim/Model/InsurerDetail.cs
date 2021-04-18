using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.Model
{
    public class InsurerDetail
    {
        public long id { get; set; }
        public String insurerName { get; set; }
        public String insurerPackageName { get; set; }
        public double insuranceAmountLimit { get; set; }
        public int disbursementDuration { get; set; }
    }
}
