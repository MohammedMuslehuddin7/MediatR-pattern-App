using AutoMapper;
using MediatR;
using MediatR1.MediatR.Commands;
using MediatR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Handlers
{
    public class RemoveVoterHandlerInfo:IRequestHandler<RemoveVoterInfoCommand,bool>
    {
        private ToDoTaskContext _context;
        private IMapper _mapper;
        public RemoveVoterHandlerInfo(ToDoTaskContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<bool> Handle(RemoveVoterInfoCommand data,CancellationToken token)
        {
            //Do not need these lines of mapping.
            //VoterInfo obj = _mapper.Map<VoterInfo>(data);
            VoterInfo obj = _context.VoterInfo.FirstOrDefault(x => x.VoterId == data.VoterId);
            if (obj != null)
            {
                _context.VoterInfo.Remove(obj);
                _context.SaveChanges();
            }
            return Task.FromResult(true);
        }
    }
}
