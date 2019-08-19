using MediatR;
using MediatR1.MediatR.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Handlers
{
    public class ReadNumberHandler:IRequestHandler<ReadNumber,int>
    {
        public Task<int> Handle(ReadNumber read,CancellationToken token)
        {
            int a = read.Number1;
            return Task.FromResult(a);
        }
    }
}
