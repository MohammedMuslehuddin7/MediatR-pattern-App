using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.MediatR.Queries
{
    public class ReadNumber:IRequest<int>
    {
        public int Number1 { get; set; }
    }
}
