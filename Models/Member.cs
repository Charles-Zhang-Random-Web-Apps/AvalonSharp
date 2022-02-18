using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvalonSharp.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }

        #region Game Session Data
        public bool IsGroupA { get; set; }
        public string MemberNote { get; set; }
        public bool IsLikelySpy { get; set; }
        public bool IsLikelyAccomplice { get; set; }
        public bool IsLikelySpyLead { get; set; }
        #endregion
    }
}
