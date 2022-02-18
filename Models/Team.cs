using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvalonSharp.Models
{
    public class Team
    {
        public Member Leader { get; set; }
        public HashSet<Member> Teammates { get; set; } = new HashSet<Member>();
        public Dictionary<Member, Vote> Votes = new Dictionary<Member, Vote>();
        public bool? Success { get; set; } = null;
    }
}
