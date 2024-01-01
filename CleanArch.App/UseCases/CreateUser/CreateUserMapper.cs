using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.App.UseCases.CreateUser
{   
    // create mapping between objects
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
          CreateMap<CreateUserRequest, User>();
          CreateMap<User, CreateUserResponse>();
        }
    }
}