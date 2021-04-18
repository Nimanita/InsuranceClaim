using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceClaim.Model;

namespace InsuranceClaim.Repository
{
    public class InitiateClaimRepository
    {
       // public InsurerDetailRepository idr = new InsurerDetailRepository();
        public static List<InitiateClaim> initiateClaim = new()
        {
            new InitiateClaim()
            {
                id = 1,
                patientName = "deepika",
                ailment = "Orthopaedics",
                cost = 2500,
                treatmentPackageName = "Package1",
                insurerName = "chaitanya"


            },
            new InitiateClaim()
            {
                id = 2,
                patientName = "lahari",
                ailment = "Orthopaedics",
                cost = 3000,
                treatmentPackageName = "Package2",
                insurerName = "rachel"


            },
            new InitiateClaim()
            {
                id = 3,
                patientName = "akshay",
                ailment = "Urology",
                cost = 4000,
                treatmentPackageName = "Package1",
                insurerName = "akshay"


            },
            new InitiateClaim()
            {
                id = 4,
                patientName = "andria",
                ailment = "urology",
                cost = 5000,
                treatmentPackageName = "Package2",
                insurerName = "athira"


            }

        };
        public InitiateClaimRepository()
        {
            if (initiateClaim == null)
                initiateClaim = new List<InitiateClaim>();
        }
        public void AmountToBePaid()
        {
            

        }
    }
}
