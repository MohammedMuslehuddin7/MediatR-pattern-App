using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Commands
{
    public class RemoveVoterInfoCommand:IRequest<bool>
    {
        public int VoterId { get; set; }
    }
}
