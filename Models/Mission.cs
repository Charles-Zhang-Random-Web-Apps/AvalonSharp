using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvalonSharp.Models
{
    public class Mission
    {
        public bool Success => FailCount == 0;
        public int FailCount { get; set; }
        public List<Member> Members { get; set; }

        public Mission(int failCount, List<Member> members)
        {
            FailCount = failCount;
            Members = members;
        }
    }
}
