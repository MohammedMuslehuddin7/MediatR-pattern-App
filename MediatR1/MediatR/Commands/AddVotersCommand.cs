using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Commands
{
    public class AddVotersCommand:IRequest<bool>
    {
        public int VoterId { get; set; }
        public string VoterFirstName { get; set; }
        public string VoterState { get; set; }
        public string VoterCounty { get; set; }
    }
}
