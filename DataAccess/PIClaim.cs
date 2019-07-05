using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PIClaim
    {
        public int PIClaimId { get; private set; }

        public int ClaimIdenfier { get; private set; }
        public Claim Claim { get; private set; }

        public decimal? Deductible { get; set; }
        public decimal? Amount { get; set; }

    }
}
