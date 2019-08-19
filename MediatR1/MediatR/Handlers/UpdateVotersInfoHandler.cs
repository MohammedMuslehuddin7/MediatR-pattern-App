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

    public class UpdateVotersInfoHandler:IRequestHandler<UpdateVotersInfoCommand,bool>
    {
        private ToDoTaskContext _context;
        private IMapper _mapper;
        public UpdateVotersInfoHandler(ToDoTaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<bool> Handle(UpdateVotersInfoCommand data, CancellationToken token)
        {

            VoterInfo obj = _mapper.Map<VoterInfo>(data);
                _context.VoterInfo.Update(obj);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
