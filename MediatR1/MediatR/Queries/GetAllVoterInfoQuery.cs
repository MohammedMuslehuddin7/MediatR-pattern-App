using MediatR;
using MediatR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Queries
{
    public class GetAllVoterInfoQuery:IRequest<List<VoterInfo>>
    {
    }
}
