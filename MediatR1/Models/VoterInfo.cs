using System;
using System.Collections.Generic;

namespace MediatR1.Models
{
    public partial class VoterInfo
    {
        public int VoterId { get; set; }
        public string VoterFirstName { get; set; }
        public string VoterState { get; set; }
        public string VoterCounty { get; set; }
    }
}
