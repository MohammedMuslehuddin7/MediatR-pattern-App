using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Commands
{
    public class AddNumbersCommand:IRequest<int>
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }
}
