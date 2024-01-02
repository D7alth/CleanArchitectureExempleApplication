using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.App.UseCases.GetAllUser
{
    public class GetAllUsersMapper : Profile
    {
        public GetAllUsersMapper()
        {
          CreateMap<User, GetAllUsersResponse>();
        }
    }
}