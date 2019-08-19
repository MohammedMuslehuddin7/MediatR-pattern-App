using MediatR;
using MediatR1.MediatR.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Handlers
{
    public class AddNumbersHandler:IRequestHandler<AddNumbersCommand,int>
    {
        public Task<int> Handle(AddNumbersCommand numbers,CancellationToken token)
        {
            int c = numbers.Number1 + numbers.Number2;
            return Task.FromResult(c);
        }
    }
}
