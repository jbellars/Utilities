using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class HelperEnums
    {
        public enum States
        {
            AA = 1, AE, AK, AL, AP, AR, AS, AZ, CA, CO,
            CT, DC, DE, FL, GA, GU, HI, IA, ID, IL, IN,
            KS, KY, LA, MA, MD, ME, MI, MN, MO, MP, MS,
            MT, NC, ND, NE, NH, NJ, NM, NV, NY, OH, OK,
            OR, PA, PR, RI, SC, SD, TN, TX, UT, VA, VI,
            VT, WA, WI, WV, WY
        }

        public enum IPEDS_Categories
        {
            Unknown = 0,
            NonResidentAlien, // 1
            RaceAndEthnicityUnknown, // 2
            HispanicOfAnyEthnicity, // 3
            AmericanIndianOrAlaskaNative, // 4
            Asian, // 5
            BlackOrAfricanAmerican, // 6
            NativeHawaiianOrOtherPacificIslander, // 7
            White, // 8
            TwoOrMoreRaces // 8
        }

        public enum GenderCodes
        {
            U = 0,
            F,
            M,
            X
        }

        public enum MaritalStati
        {
            Unknown = 0,
            Single,
            Married,
            Divorced,
            Separated,
            CivilPartnership
        }
    }
}
