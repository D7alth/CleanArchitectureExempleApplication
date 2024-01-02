using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.App.UseCases.DeleteUser
{
    public class DeleteUserMapper : Profile
    {
        public DeleteUserMapper()
        {
          CreateMap<DeleteUserRequest, User>();
          CreateMap<User, DeleteUserResponse>();
        }
    }
}