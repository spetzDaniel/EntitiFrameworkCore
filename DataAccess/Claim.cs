using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess
{
    public class Claim
    {
        [Required]
        public int ClaimIdenfier { get; set; }
        public int ClaimNo { get; set; }
        public int PolicyYear { get; set; }
        public string Memo { get; set; }
        public string Inser_User { get; set; }
        public byte[] RowVersion { get; set; }

        private List<PIClaim> piClaimsList = new List<PIClaim>();
        public IEnumerable<PIClaim> PiClaimsList => piClaimsList;

    }
}
