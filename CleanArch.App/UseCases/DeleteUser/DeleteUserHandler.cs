using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.App.Interfaces;
using CleanArch.App.Interfaces.Users;
using MediatR;
using CleanArch.Domain.Entities;

namespace CleanArch.App.UseCases.DeleteUser
{
    public class DeleteUserHandler(IUnitOfWork unitOfWork, IUsersRepository usersRepository, IMapper mapper) :
      IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IUsersRepository _usersRepository = usersRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
          var user = await _usersRepository.Get(request.Id, cancellationToken);
          if (user == null) return default;
          _usersRepository.Delete(user);
          await _unitOfWork.Commit(cancellationToken);
          return _mapper.Map<DeleteUserResponse>(user);
        }

    }
}