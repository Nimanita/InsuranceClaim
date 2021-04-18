using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceClaim.Model;

namespace InsuranceClaim.Repository
{
    public class InsurerDetailRepository
    {
        public static List<InsurerDetail> insurerDetails = new()
        {
            new InsurerDetail()
            {
                id = 1,
                insurerName = "chaitanya",
                insurerPackageName = "Ipackage1",
                insuranceAmountLimit = 1000,
                disbursementDuration = 4
            },
            new InsurerDetail()
            {
                id = 2,
                insurerName = "rachel",
                insurerPackageName = "Ipackage2",
                insuranceAmountLimit = 2000,
                disbursementDuration = 6
            },
            new InsurerDetail()
            {
                id = 3,
                insurerName = "akshay",
                insurerPackageName = "Ipackage1",
                insuranceAmountLimit = 1000,
                disbursementDuration = 4
            },
            new InsurerDetail()
            {
                id = 4,
                insurerName = "athira",
                insurerPackageName = "Ipackage2",
                insuranceAmountLimit = 2000,
                disbursementDuration = 6
            }
        };
        public InsurerDetailRepository()
        {
            if (insurerDetails == null)
                insurerDetails = new List<InsurerDetail>();
        }
        public InsurerDetail GetInsurerByPackageName(String PackageName)
        {
            InsurerDetail insurerPackage = new();
            foreach (var pack in insurerDetails)
                if (pack.insurerPackageName == PackageName)
                    insurerPackage = pack;
            return insurerPackage;
        }
        public List<InsurerDetail> GetAllInsurerDetail()
        {
            List<InsurerDetail> AllPackages = new();
            foreach (var pack in insurerDetails)
                AllPackages.Add(pack);
            return AllPackages;
        }
    }
}
