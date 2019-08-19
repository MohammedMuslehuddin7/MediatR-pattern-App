using MediatR;
using MediatR1.MediatR.Queries;
using MediatR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Handlers
{
    public class GetAllVoterInfoHandler:IRequestHandler<GetAllVoterInfoQuery,List<VoterInfo>>
    {
        private ToDoTaskContext _context;
        public GetAllVoterInfoHandler(ToDoTaskContext context)
        {
            _context = context;
        }
        public Task<List<VoterInfo>> Handle(GetAllVoterInfoQuery data,CancellationToken token)
        {
            var obj = _context.VoterInfo.ToList();
            return Task.FromResult(obj);
        }
    }
}
