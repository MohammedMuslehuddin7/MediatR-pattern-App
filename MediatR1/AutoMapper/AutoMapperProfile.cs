using AutoMapper;
using MediatR1.MediatR.Commands;
using MediatR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR1.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddVotersCommand, VoterInfo>();
        }
    }
}
