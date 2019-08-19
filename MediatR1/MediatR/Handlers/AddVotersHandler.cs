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
    public class AddVotersHandler:IRequestHandler<AddVotersCommand,bool>
    {
        private ToDoTaskContext _context;
        private IMapper _mapper;
        public AddVotersHandler(ToDoTaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<bool> Handle(AddVotersCommand data, CancellationToken token)
        {
            VoterInfo obj = _mapper.Map<VoterInfo>(data);
            _context.VoterInfo.Add(obj);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
